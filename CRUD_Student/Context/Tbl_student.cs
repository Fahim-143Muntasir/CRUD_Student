//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_Student.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Tbl_student
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Rquired")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Rquired")]
        public string LastName { get; set; }

        
        [Required(ErrorMessage = "Rquired")]
        [EmailAddress(ErrorMessage ="This is not a valid email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Rquired")]
        [MinLength(11,ErrorMessage ="Number should be of 11 digits")]
        public string Mobile { get; set; }
        public string Description { get; set; }
    }
}