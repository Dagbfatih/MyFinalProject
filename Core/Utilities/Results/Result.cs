using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success) // this(success) = Result(success)
        {
            Message = message; // MEssage sadece get;'ti ama burada set edebildik. Nedeni ise constructorlarda sadece get; olanlar set edilebilir. Sadece constructorlar için istisnadır
            //Success = success; ||| burayı sildim çünkü aşağıda zaten var. Oradakini de çalıştırdım this ile
        }

        public Result(bool success) // overloading: aşırı yükleme | iki constructor yazdık, biri sadece bool girersek, biri iki parametreyide girersek çalışır. Buna da overloading denir
        {
            Success = success;
        }

        public bool Success { get; } // throw new NotImplementedException() ifadesi yerine döndüreceği şey yazılır. (return edilecek ifade)

        public string Message { get; }
    }
}
