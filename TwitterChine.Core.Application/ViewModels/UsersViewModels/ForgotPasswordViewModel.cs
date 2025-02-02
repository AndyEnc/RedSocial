﻿using System.ComponentModel.DataAnnotations;

namespace TwitterChine.Core.Application.ViewModels.UsersViewModels
{
    public class ForgotPasswordViewModel
    {

        [Required(ErrorMessage = "ESTE CAMPO ES REQUERIDO")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
