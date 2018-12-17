using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace KentApp.Helper
{
    public class AppConstants
    {

        public static  String connectionString = ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString;
    }
}