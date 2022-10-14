using System.ComponentModel.DataAnnotations;

namespace Code_First.Models
{
    public class Trainee
    {
        [Key]
        public int TraineeID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        
        public string? TraineeName { get; set; }

        [Range(21, 58, ErrorMessage = "Enter age between 21 to 58")]
        public int TraineeAge { get; set; }

        public DateTime TraineeDOJ { get; set; }
        public DateTime TraineeDOB { get; set; }

        
        public string? TraineeMobile { get; set; }

       
        public string? TraineeEmail { get; set; }

        
        [Required(ErrorMessage = "Enter the Password")]
        public string? TraineePassword { get; set; }

        
        [Required(ErrorMessage = "Enter the Confirm Password")]
        [Compare("TraineePassword", ErrorMessage = "Password does not match")]
        public string? TraineeConfirmPassword { get; set; }
    }
}
