using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using GymMang.Data;
using GymMang.ViewModel;

namespace GymMang.Controllers
{
    public class FeeVoucherController : Controller
    {

        private readonly GymDbContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public FeeVoucherController(GymDbContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            _dbContext = dbContext;
            this._webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index(string selected_rbt, string selectedDate)
        {
            ViewBag.Selectedbutton = selected_rbt;
            ViewBag.SelectedDate = selectedDate;
            var result = GetGymeTraineeFeeStatus(selected_rbt, selectedDate);

            return View((IEnumerable<GymTraineeDetailViewModel>)result);

        }
        //dynamic GetGymeTraineeFeeStatus(string selected_rbt, string selectedDate)
        IEnumerable<GymTraineeDetailViewModel> GetGymeTraineeFeeStatus(string selected_rbt, string selectedDate)
        {
            if (string.IsNullOrEmpty(selected_rbt))
            {
                selected_rbt = "List";
            }

            IEnumerable<GymTraineeDetailViewModel> result = null;

            if (selected_rbt == "list")
            {
                result = from t in _dbContext.Trainees
                         join mfv in _dbContext.MonthlyFeeVouchers on t.TraineeId equals mfv.TraineeId into fee_Details
                         from mfv in fee_Details.DefaultIfEmpty()
                         where (mfv.Status == selected_rbt)
                         select new GymTraineeDetailViewModel
                         {
                             monthlyFeeVoucher = mfv,
                             gymTrainee = t
                         };
            }
            else if (selected_rbt == "Paid")
            {
                result = from t in _dbContext.Trainees
                         join mfv in _dbContext.MonthlyFeeVouchers on t.TraineeId equals mfv.TraineeId into fee_Details
                         from mfv in fee_Details.DefaultIfEmpty()
                         where (mfv.Status == selected_rbt)
                         select new GymTraineeDetailViewModel
                         {
                             monthlyFeeVoucher = mfv,
                             gymTrainee = t
                         };
            }
            else if (selected_rbt == "Un-Paid")
            {
                result = from t in _dbContext.Trainees
                         join mfv in _dbContext.MonthlyFeeVouchers on t.TraineeId equals mfv.TraineeId into fee_Details
                         from mfv in fee_Details.DefaultIfEmpty()
                         where (mfv.FeeDate == null)
                         select new GymTraineeDetailViewModel
                         {
                             monthlyFeeVoucher = mfv,
                             gymTrainee = t
                         };
            }

            return result ?? Enumerable.Empty<GymTraineeDetailViewModel>();
        }


   


    public IActionResult PayMonthlyFee()
        {
            return View();
        }
    }
}


