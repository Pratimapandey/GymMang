using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymMang.Models
{
    public class GymTrainee
    {
        [Key]
        public int TraineeId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        
        [DisplayName("ContactNo")]
        public string ContactNo { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Age")]
        public string Age { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Height")]
       
        public string Height { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Weight")]
        public int Weight { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }
        public DateTime CreationDate { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }


        [NotMapped]
        public string _feepaid_status = "unknown";






        public int TrainingLevelID { get; set; }
        public virtual TrainingLevel TrainingLevel { get; set; }


        public int MonthlyFee { get; set; }
   


    }
}
