using GymMang.Data;
using GymMang.Models;
using GymMang.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GymMang.Controllers
{
    public class GymTraineeController : Controller
    {
        private readonly GymDbContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GymTraineeController(GymDbContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            _dbContext = dbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult SaveTraineeInfo(int Id)
        {
            #region Training Level
            List<SelectListItem> trainingLevelList = new List<SelectListItem>();
            var trainingLevels = _dbContext.TrainingLevels.ToList();
            foreach (var item in trainingLevels)
            {
                trainingLevelList.Add(new SelectListItem() { Text = item.TrainingLevelName, Value = item.TrainingLevelID.ToString() });
            }
            ViewBag.TLL = trainingLevelList;
            #endregion

            if (Id == 0)
            {
                return View(new GymTrainee());
            }
            else
            {
                var selected_gym_trainee = _dbContext.Trainees.Find(Id);
                return View(_dbContext.Trainees.Find(Id));
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveTraineeInfo([Bind("TraineeId, FirstName,ContactNo, LastName,Age,Height, Weight,Gender, Address ,TrainingLevelID,MonthlyFee,ImageFile")] GymTrainee gymTrainee)
        {
            try
            {
               
                    if (gymTrainee.ImageFile != null)
                    {
                        if (gymTrainee.TraineeId == 0)
                        {


                            string wwwRootPath = _webHostEnvironment.WebRootPath;
                            string fileName = Path.GetFileNameWithoutExtension(gymTrainee.ImageFile.FileName);
                            string extension = Path.GetExtension(gymTrainee.ImageFile.FileName);
                            gymTrainee.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                            string path = Path.Combine(wwwRootPath + "/Images/", fileName);
                            using (var fileStream = new FileStream(path, FileMode.Create))
                            {
                                await gymTrainee.ImageFile.CopyToAsync(fileStream);
                            }
                            gymTrainee.CreationDate =DateTime.Now;
                            _dbContext.Add(gymTrainee);
                            await _dbContext.SaveChangesAsync();
                        }
                        if (gymTrainee.TraineeId > 0)
                        
                            {

                                string wwwRootPath = _webHostEnvironment.WebRootPath;
                                string fileName = Path.GetFileNameWithoutExtension(gymTrainee.ImageFile.FileName);
                                string extension = Path.GetExtension(gymTrainee.ImageFile.FileName);
                                gymTrainee.ImageName = fileName + DateTime.Now.ToString("yymmssff") + extension;
                                string path = Path.Combine(wwwRootPath, "Images", gymTrainee.ImageName);

                                using (var fileStream = new FileStream(path, FileMode.Create))
                                {
                                    await gymTrainee.ImageFile.CopyToAsync(fileStream);
                                }
                            

                            gymTrainee.CreationDate = DateTime.Now;
                            _dbContext.Update(gymTrainee);
                          
                            await _dbContext.SaveChangesAsync();

                            return RedirectToAction(nameof(SaveTraineeInfo));
                        }
                        else
                        {

                            List<SelectListItem> trainingLevelList = new List<SelectListItem>();
                            var trainingLevels = _dbContext.TrainingLevels.ToList();
                            foreach (var item in trainingLevels)
                            {
                                trainingLevelList.Add(new SelectListItem() { Text = item.TrainingLevelName, Value = item.TrainingLevelID.ToString() });
                            }
                            ViewBag.TLL = trainingLevelList;
                        }
                        return View(gymTrainee);
                      }
                }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return View(gymTrainee);
        }


        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _dbContext.Trainees.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            List<SelectListItem> trainingLevelList = new List<SelectListItem>();
            var trainingLevels = _dbContext.TrainingLevels.ToList();
            foreach (var item in trainingLevels)
            {
                trainingLevelList.Add(new SelectListItem() { Text = item.TrainingLevelName, Value = item.TrainingLevelID.ToString() });
            }
            ViewBag.TLL = trainingLevelList;
            return View("SaveTraineeInfo", pet);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PetId,PetName,PetOwnerName,PetAddress,ImageName,ImageFile")] GymTrainee pet)
        {
            if (id != pet.TraineeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Attach(pet).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.TraineeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pet);
        }

        private bool PetExists(int traineeId)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            var traineesList = _dbContext.Trainees.Include(t => t.TrainingLevel).ToList();

            var traineeDetailsList = traineesList.Select(trainee => new GymTraineeDetailViewModel
            {
                gymTrainee = trainee,
                trainingLevel = trainee.TrainingLevel

            }).ToList();

            return View(traineeDetailsList);

        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult > DeleteConfirmed(int Id)
        {
            var pet = await _dbContext.Trainees.FindAsync(Id);
            _dbContext.Trainees.Remove(pet);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
