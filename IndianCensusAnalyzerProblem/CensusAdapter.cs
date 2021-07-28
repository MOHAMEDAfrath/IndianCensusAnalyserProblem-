using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyzerProblem
{
   public class CensusAdapter
    {
        public string[] GetCensusData(string csvFilePath,string dataHeaders)
        {
            string[] censusData;
            if (!File.Exists(csvFilePath))
                throw new CensusCustomException(CensusCustomException.ExceptionType.FILE_NOT_FOUND, "File not found!");
            censusData = File.ReadAllLines(csvFilePath);
            return censusData;
        }
    }
}
