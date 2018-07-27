using System;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        String Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        [DataType(DataType.Password)]
        String Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        String ConfirmPassword { get; set; }

        public RegisterViewModel()
        {
        }
    }
}
