using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        //Overloading aşırı yüklenme yaptık
        public Result(bool success)
        {
            Success = success;
        }

        //get ler yani read only Constructor'da set edilebilir
        public bool Success { get; }

        public string Message { get; }
    }
}
