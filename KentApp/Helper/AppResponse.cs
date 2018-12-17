using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KentApp.Helper
{
    public class AppResponse<T>
    {
        public T Data { get; set; }
        public bool ErrorStatus { get; set; }
        public AppError ErrorDetails { get; set; }

        public AppResponse(bool ErrorStatus,T Data)
        {
            this.Data = Data;
            this.ErrorStatus = ErrorStatus;
        }

    }
}