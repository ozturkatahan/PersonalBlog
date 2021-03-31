using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Shared.Utilities.Concrete
{
    // Bu class işlemlerin başarılı olup olmadığını döndürmek için. (Announcing işlemleri)
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }
        public Result(ResultStatus resultStatus, string info)
        {
            ResultStatus = resultStatus;
            Info = info;
        }
        public Result(ResultStatus resultStatus, string info, Exception exception)
        {
            ResultStatus = resultStatus;
            Info = info;
            Exception = exception;
        }
        public ResultStatus ResultStatus { get; }

        public string Info { get; }

        public Exception Exception { get; }
    }
}
