using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyzerProblem
{
    //For Open Closed Principle
    public abstract class CsvOperations
    {
        public abstract string[] GetCensusData(string csvFilePath, string dataHeaders);
    }
    //interface segregation principle
    public interface ICountryCsvOperations
    {
         void LoadCountryCsv(string fileCsvPath, string header);
    }
    public interface IStateCodeCsvOperations
    {
        void LoadStateCsv(string fileCsvPath, string header);

    }
}
