using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TestLife.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Login", Prompt = "Your login word")]
        [StringLength(60)]
        public String Login { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Password")]     
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Display(Name = "Remember me")]
        public bool Remember { get; set; }
    }
}