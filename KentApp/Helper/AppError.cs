using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KentApp.Helper
{
    public class AppError
    {
        public ErrorCodes ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public AppError(ErrorCodes ErrorCode, string ErrorMessage)
        {
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
        }
    }

    public enum ErrorCodes
    {
        //all the unauthorized request
        UNAUTHORIZED = 404,
        //can not find requested item
        NOT_FOUND = 100,
        //unknown error
        UNKNOWNERROR = 300,
        //unknown user
        UNKNOWNUSER = 301,
        //Database error
        DBERROR = 302,
        //Database id not found
        DBID_NOT_FOUND = 303,
        //Insufficient Result
        INSUFFICIENT_RESULT = 801,
        DUPLICATE_ENTRY = 408,
        //WRONG INPUT GIVEN
        WRONG_INPUT = 501,
        //EXCEPTION OCCURED
        EXCEPTION_OCCURED = 555,
        //table is not exist
        TABLE_NOT_EXIST = 700,
        //accessed by another user
        ACCESSED_BY_ANOTHER_USER = 500,
        //OPERATION IS FAILD
        TABLE_OPERATION_UNSUCCESS = 510,
        //INSUFFICIENT PARAMS
        INSUFFICIENT_PARAM = 600,
        //ITEMS NOT PRINTED 
        ITEMS_NOT_PRINTED_IN_KITCHEN = 701,
        //invalid license format
        INVALID_LICENSE_FORMAT = 900,
        //invalid license
        INVALID_LICENSE = 901,
        //max license reached
        MAX_DEVICE_ADDED = 902,
        //could not find licensed device
        LICENSED_DEVICE_NOT_FOUND = 903,
        //could not find licensed device
        AUTHORIZATION_ERROR = 904,
        INVALID_KEY =502,
        KEY_EXPRIED = 503,

        //version mismatch
        VERSION_MISMATCH = 304,
        INSERTION_FAILS = 500

        




    }
    public static class ErrorMessage
    {
        public const string PARMA_REQUIRED = "Please provide required parameters";
        public const string EXECPTION = "Exeception occured";
        public const string INSERTION_FAILED = "Insertion failed";
        public const string INVALID_KEY = "Invalid key provided";
        public const string KEY_EXPIRED = "Registration key expired";
        public const string RESULT_NOT_FOUND = "Couldn't get data from DB Server";
        public const string ITEM_NOT_FOUND = "Requested item is not found";
    }
}