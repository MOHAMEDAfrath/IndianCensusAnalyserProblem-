using IndianCensusAnalyzerProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IndianCensusProject
{
    [TestClass]
    public class UnitTest1
    {
        CsvOperations censusAdapter;
       ICountryCsvOperations censusAnalyzer;
        string censusFilePath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\IndianStateCensusInformation.csv";
        string invalidFileCsvPath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\InvalidCensusFile.csv";
        string invalidFileTypePath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\InvalidCensusFile.csa";
        string invalidDelimiterFilePath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\IndianStateCensusWithInvalidDelimiter.csv";
        string invalidHeaderFilePath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\IndianStateCensusWithInvalidHeader.csv";
        string stateCodeFilePath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\IndianStateCode.csv";
        string stateCodeInvalidFilePath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\InvalidIndianStateCode.csv";
        string stateCodeInvalidFileTypePath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\InvalidIndianStateCode.csa";
        string stateCodeInvalidFileDelimiterPath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\InvalidIndianStateDelimiterCode.csv";
        string stateCodeInvalidFileHeaderPath = @"C:\Users\mohamedafrath.s\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyzerProblem\InvalidIndianStateHeaderCode.csv";




        [TestInitialize]
        public void SetUp()
        {
            censusAdapter = new CensusAdapter();
            censusAnalyzer = new CensusAnalyzer();
        }
        //TC1.1:Given the States Census CSV file, Check to ensure the Number of Record matches
        [TestMethod]
        [TestCategory("Given the States Census CSV file, Check to ensure the Number of Record matches")]
        public void TestMethodToCheckCountOfDataRetrieved()
        {
            //Excluding Header
            int expected = 28;
            string[] result = censusAdapter.GetCensusData(censusFilePath, "State,Population,Increase,Area(Km2),Density,Sex-Ratio,Literacy");
            int actual = result.Length - 1;
            Assert.AreEqual(expected, actual);
        }
        //TC1.2:Given the State Census CSV File if incorrect Returns a custom Exception
        [TestMethod]
        [TestCategory("Invalid File Name")]
        public void TestMethodToCheckInvalidFileName()
        {
            try
            {
                censusAdapter.GetCensusData(invalidFileCsvPath, "State,Population,Increase,Area(Km2),Density,Sex-Ratio,Literacy");

            }catch(CensusCustomException ex)
            {
                Assert.AreEqual(ex.Message, "File not found!");
            }
        }

        //TC1.3:Given the State Census CSV File when correct but type incorrect Returns a custom Exception
        [TestMethod]
        [TestCategory("Invalid File Type")]
        public void TestMethodToCheckInvalidFileType()
        {
            try
            {
                censusAdapter.GetCensusData(invalidFileTypePath, "State,Population,Increase,Area(Km2),Density,Sex-Ratio,Literacy");

            }
            catch (CensusCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Invalid file type");
            }
        }
        //TC1.4:Given the State Census CSV File when correct but delimiter incorrect Returns a custom Exception
        [TestMethod]
        [TestCategory("Invalid Delimiter")]
        public void TestMethodToCheckInvalidDelimiter()
        {
            try
            {
                censusAnalyzer.LoadCountryCsv(invalidDelimiterFilePath, "State.Population.Increase.Area(Km2).Density.Sex-Ratio.Literacy");

            }
            catch (CensusCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Delimiter");
            }
        }
        //TC1.5:Given the State Census CSV File when correct but csv header incorrect Returns a custom Exception
        [TestMethod]
        [TestCategory("Invalid Header")]
        public void TestMethodToCheckInvalidHeader()
        {
            try
            {
                censusAnalyzer.LoadCountryCsv(invalidHeaderFilePath, "State,Population,Increase,Area(Km2),Density,Sex-Ratio,Literacy");
            }
            catch(CensusCustomException ex)
            {
                Assert.AreEqual(ex.Message,"Incorrect Header");
            }
        }
        //TC2.1:Given the State Code CSV file, Check to ensure the Number of Record matches
        [TestMethod]
        [TestCategory("Given the State Code CSV file, Check to ensure the Number of Record matches")]
        public void TestMethodToCheckCountOfDataRetrieved_StateCodeCsv()
        {
            //Excluding Header
            int expected = 11;
            string[] result = censusAdapter.GetCensusData(stateCodeFilePath, "SerailNo,StateName,StateCode");
            int actual = result.Length - 1;
            Assert.AreEqual(expected, actual);
        }
        //TC2.2:Given the State Code CSV File if incorrect Returns a custom Exception
        [TestMethod]
        [TestCategory("Invalid File Name")]
        public void TestMethodToCheckInvalidFileName_StateCodeCsv()
        {
            try
            {
                censusAdapter.GetCensusData(stateCodeInvalidFilePath, "SerailNo,StateName,StateCode");

            }
            catch (CensusCustomException ex)
            {
                Assert.AreEqual(ex.Message, "File not found!");
            }
        }

        //TC2.3:Given the State Code CSV File when correct but type incorrect Returns a custom Exception
        [TestMethod]
        [TestCategory("Invalid File Type")]
        public void TestMethodToCheckInvalidFileType_StateCodeCsv()
        {
            try
            {
                censusAdapter.GetCensusData(invalidFileTypePath, "SerailNo,StateName,StateCode");

            }
            catch (CensusCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Invalid file type");
            }
        }
        //TC2.4:Given the State Code CSV File when correct but delimiter incorrect Returns a custom Exception
        [TestMethod]
        [TestCategory("Invalid Delimiter")]
        public void TestMethodToCheckInvalidDelimiter_StateCodeCsv()
        {
            try
            {
                censusAnalyzer.LoadCountryCsv(stateCodeInvalidFileDelimiterPath, "SerailNo.StateName.StateCode");

            }
            catch (CensusCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Delimiter");
            }
        }
        //TC2.5:Given the State Code CSV File when correct but csv header incorrect Returns a custom Exception
        [TestMethod]
        [TestCategory("Invalid Header")]
        public void TestMethodToCheckInvalidHeader_StateCodeCsv()
        {
            try
            {
                censusAnalyzer.LoadCountryCsv(stateCodeInvalidFileHeaderPath, "SerailNo,StateName,StateCode");
            }
            catch (CensusCustomException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }


    }
}
