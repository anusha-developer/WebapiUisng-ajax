using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebapiusingAjax.Models;

namespace WebapiusingAjax.Controllers
{
    public class EmployeeController : ApiController
    {
        DBEmployeeEntities dBEmployee = new DBEmployeeEntities();
        //Add Post request
     
        public string post(Tbl_Employee tbl_Employee) 
        {
            dBEmployee.Tbl_Employee.Add(tbl_Employee);
            dBEmployee.SaveChanges();
            return "Employee Added";
        }
        //Get All records
      
        public IEnumerable<Tbl_Employee> Get()
        {
            return dBEmployee.Tbl_Employee.ToList();

        }
        //Get Single record
      
        public Tbl_Employee GetTbl_Employee(int Id)
        {
           Tbl_Employee tbl_Employee=  dBEmployee.Tbl_Employee.Find(Id);
           return tbl_Employee;
            
        }
        //Update record
      
        public string Put(int Id, Tbl_Employee tbl_Employee)
         {
             var Tbl_Employee = dBEmployee.Tbl_Employee.Find(Id);
             Tbl_Employee.EmpName = tbl_Employee.EmpName;
             Tbl_Employee.EmpEmailId = tbl_Employee.EmpEmailId;
             Tbl_Employee.EmpPhoneno = tbl_Employee.EmpPhoneno;
             Tbl_Employee.EmpAddress = tbl_Employee.EmpAddress;
             dBEmployee.Entry(Tbl_Employee).State = System.Data.Entity.EntityState.Modified;
             dBEmployee.SaveChanges();
             return "EmployeeUpdated";
         }
        //Delete Record
         public string Delete(int Id)
        {
            Tbl_Employee tbl_Employee = dBEmployee.Tbl_Employee.Find(Id);
            dBEmployee.Tbl_Employee.Remove(tbl_Employee);
            dBEmployee.SaveChanges();
            return "Deleted";
        }
        
    }
}
