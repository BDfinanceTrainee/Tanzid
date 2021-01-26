//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcCrud.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Student
    {
        [Required(ErrorMessage = "Required")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Fname { get; set; }
        
        [EmailAddress]
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Required")]
        [MinLength(11,ErrorMessage ="Mobile Number should be 11 digits")]
        public string Mobile { get; set; }
        
        public string Description { get; set; }
        
    } 
}
