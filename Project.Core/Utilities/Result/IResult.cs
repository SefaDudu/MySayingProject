using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
