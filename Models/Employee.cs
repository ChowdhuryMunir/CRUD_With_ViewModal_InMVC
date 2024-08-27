using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Helpers;

namespace CRUD_With_ViewModalI_InMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Name is Required!")]
        [StringLength(30, ErrorMessage = "Name Must Be in 20 Character")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Email Must be Required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter Employee Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Cellphone No.")]
        [MaxLength(11, ErrorMessage = "Contact Number Must be greater than 11 Digit")]
        [MinLength(11, ErrorMessage = "Contact Number Can't be less than 11 Digit")]
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}