using ConsoleLogAnalyzerLab1;
using ConsoleLogAnalyzerLab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab2Tests.Fake
{
    public class TestableLogAnalyzer: FileManagerFactoryMethod
    {
        private readonly IFileManager _fileManager;

        public TestableLogAnalyzer(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public override IFileManager GetFileManager()
        {
            return _fileManager;
        }
    }
}
