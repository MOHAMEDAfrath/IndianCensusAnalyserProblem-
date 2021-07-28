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
}
