using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace CRUD_With_ViewModalI_InMVC.Models
{
    public class DataSeeder
    {
        public void Seed(ApplicationDbContext context)
        {

            context.Employees.AddOrUpdate(
                c => c.EmployeeName,
                new Employee
                {
                    EmployeeName = "Munir Chowdhury",
                    Email = "munir@mail.com",
                    Phone = "12345678911",
                    Address = "Dhk"
                },
                new Employee
                {
                    EmployeeName = "Imtaz Tausif",
                    Email = "imtiaz@mail.com",
                    Phone = "12345678911",
                    Address = "Cum"
                }
                );
        }
    }
}