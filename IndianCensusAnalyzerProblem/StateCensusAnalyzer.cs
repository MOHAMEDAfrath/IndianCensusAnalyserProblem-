using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyzerProblem
{
    public class StateCensusAnalyzer:CsvStatesAdapter,IStateCodeCsvOperations
    {
        public void LoadStateCsv(string fileCsvPath, string header)
        {
            try
            {
                string[] result = GetCensusData(fileCsvPath, header);
                foreach (var member in result.Skip(1))
                {
                    //Checks for delimiter 
                    if (!member.Contains(","))
                        throw new CensusCustomException(CensusCustomException.ExceptionType.INVALID_DELIMITER, "Invalid Delimiter");
                }

            }
            catch (CensusCustomException ex)
            {
                throw;
            }
        }
    }
}
