using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Shared.Utilities.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus, T data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string info, T data)
        {
            ResultStatus = resultStatus;
            Data = data;
            Info = info;
        }
        public DataResult(ResultStatus resultStatus, string info, T data, Exception exception)
        {
            ResultStatus = resultStatus;
            Data = data;
            Info = info;
            Exception = exception;
        }
        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Info { get; }

        public Exception Exception { get; }
    }
}
