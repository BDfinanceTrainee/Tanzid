using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVC_Reg_User.Models
{
    public class UserClass
    {
        [Required(ErrorMessage ="Enter Username!")]
        [Display(Name = "Enter Username :" )]
        [StringLength(maximumLength:7,MinimumLength =3,ErrorMessage ="Username Length must be max 7 & min 3")]
        public string Uname { get; set; }

        [Required(ErrorMessage = "Enter NID Number!")]
        [Display(Name = "Enter NID :")]
        public string NID { get; set; }
        [Required(ErrorMessage = "Enter Date!")]
        [Display(Name = "Enter Date :")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Upload Profile Image!")]
        [Display(Name = "Profile Image :")]
        public string Uimg { get; set; }
    }
}