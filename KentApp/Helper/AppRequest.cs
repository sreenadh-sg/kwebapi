using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KentApp.Helper
{
    public class AppRequest<T>
    {
        public T Data { get; set; }
        public int UserID { get; set; }
    }
}