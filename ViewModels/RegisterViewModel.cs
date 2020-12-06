using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PH.ViewModels
{
     public class RegisterViewModel
        {
            [Required(ErrorMessage = "Это обязательное поле :")]
            [DataType(DataType.Text)]
            [Display(Name = "В качестве кого регистрируетесь :")]
            public string Role { get; set; }

            [Required(ErrorMessage = "Это обязательное поле :")]
            [DataType(DataType.Text)]
            [Display(Name = "Логин")]
            [Remote(action: "CheckLogin", controller: "Validation", ErrorMessage = "Ранее использован : ")]
            public string UserName { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Пароль")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Это обязательное поле :")]
            [Compare("Password", ErrorMessage = "Пароли не совпадают")]
            [DataType(DataType.Password)]
            [Display(Name = "Подтвердить пароль")]
            public string PasswordConfirm { get; set; }
    
        }
}