using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleLogAnalyzerLab2;
using ConsoleLogAnalyzerLab2Tests.Fake;
using ConsoleLogAnalyzerLab2Tests;

namespace ConsoleLogAnalyzerLab1.Tests
{
    [TestClass()]
    public class LogAnalyzerTests
    {
        [TestMethod()]
        public void Test_IsValidLogFileName()
        {
            // Arrange
            LogAnalyzer target = new LogAnalyzer();
            bool expected = true;
            bool actual;

            string fileName = "20200102.log";

            // Act
            actual = target.IsValidLogFileName(fileName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsValidLogFileName_Stub()
        {
            // Arrange
            IFileManager fileManager = new FileManager();

            fileManager.SetFileUtility = new FakeFileUtility();

            TestableLogAnalyzer target = new TestableLogAnalyzer(fileManager);

            string fileName = "20200102.log";
            bool expected = true;
            bool actual;


            // Act
            actual = target.IsValidLogFileName(fileName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}