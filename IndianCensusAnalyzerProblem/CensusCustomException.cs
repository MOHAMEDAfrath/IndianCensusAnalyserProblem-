using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyzerProblem
{
    public class CensusCustomException:Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,INVALID_FILE_TYPE,INCORRECT_HEADER,INVALID_DELIMITER
        }
        ExceptionType exceptionType;
        public CensusCustomException(ExceptionType exceptionType, string message) :base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
