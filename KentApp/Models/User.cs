using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KentApp.Models
{
    public class User
    {

      public String UserID {get;set;}
      public String EmployeeCode {get;set;}
      public String EmployeeName {get;set;}
      public int Designation {get;set;}
      public int RoleID {get;set;}
      public String Username {get;set;}
      public String Password {get;set;}
      public String ContactNo {get;set;}
      public String Email {get;set;}
    }
}