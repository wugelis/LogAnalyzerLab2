using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ConsoleLogAnalyzerLab2;

namespace ConsoleLogAnalyzerLab1.Tests
{
    [TestClass()]
    public class LogAnalyzerTests
    {
        [TestMethod()]
        public void Test_IsValidLogFileName()
        {
            // Arrange
            string fileName = "20200102.log";
            bool expected = true;
            bool actual;

            Mock<IFileUtility> fileUtility = new Mock<IFileUtility>();
            fileUtility
                .Setup(c => c.CheckFileExists(fileName))
                .Returns(true);

            IFileManager target = new FileManager();
            target.SetFileUtility = fileUtility.Object;

            // Act
            actual = target.IsValid(fileName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}