﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Webshop.Models.AccountViewModels
{
    public class SiteUserViewModel
    {
        /// <summary>
        /// User's full name.
        /// </summary>
        [Required(ErrorMessage = "You must enter a Name.")]
        [StringLength(70, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public String Name { get; set; }

        /// <summary>
        /// User's email address
        /// </summary>
        [Required(ErrorMessage = "You must enter an Email Address.")]
        [EmailAddress(ErrorMessage = "Email Address in invalid format.")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
    }
}
