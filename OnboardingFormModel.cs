using System.ComponentModel.DataAnnotations;

namespace OnboardingForm.Models
{
    public class OnboardingFormModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please select your gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        public string Country { get; set; }
    }
}
