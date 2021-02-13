using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> // sen aslında bir Resultsın. Yani sen result'ın içindekileri içeriyorsun.
    {
        public DataResult(T data, bool success, string message):base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
