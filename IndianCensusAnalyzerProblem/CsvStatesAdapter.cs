using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyzerProblem
{
   public class CsvStatesAdapter:CsvOperations
    {
        public override string[] GetCensusData(string csvStateFilePath, string dataHeaders)
        {
            string[] statusData;
            if (!File.Exists(csvStateFilePath))
                throw new CensusCustomException(CensusCustomException.ExceptionType.FILE_NOT_FOUND, "File not found!");
            else if (Path.GetExtension(csvStateFilePath) != ".csv")
                throw new CensusCustomException(CensusCustomException.ExceptionType.INVALID_FILE_TYPE, "Invalid file type");
            statusData = File.ReadAllLines(csvStateFilePath);
            if (statusData[0] != dataHeaders)
                throw new CensusCustomException(CensusCustomException.ExceptionType.INCORRECT_HEADER, "Incorrect Header");
            return statusData;
        }
    }
}
