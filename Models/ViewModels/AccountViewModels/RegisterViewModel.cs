using System;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models.ViewModels.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The first name must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "MiddleName")]
        [StringLength(100, ErrorMessage = "The middle name must be at max {1} characters long.")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The last name must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "BirthDate")]
        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
