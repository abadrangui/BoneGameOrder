﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoneGameOrder.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Мэйл хаягаа заавал оруулна уу!")]
        [Display(Name = "Мэйл хаяг")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Нууц үг заавал оруулна уу!")]
        [DataType(DataType.Password)]
        [Display(Name = "Нууц үг")]
        public string Password { get; set; }

        [Display(Name = "Нууц үг санах?")]
        public bool RememberMe { get; set; }
    }


    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Мэйл хаягаа заавал оруулна уу!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Нууц үг тохирохгүй байна.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Хэрэглэгчийн нэр")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Овогоо оруулна уу!")]
        [Display(Name = "Овог")]
        public string SureName { get; set; }

        [Required(ErrorMessage = "Нэрээ оруулна уу!")]
        [Display(Name = "Нэр")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Утасны дугаар")]
        public string PhoneNumber { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
