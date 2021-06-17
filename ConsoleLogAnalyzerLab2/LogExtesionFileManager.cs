using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab2
{
    public class LogExtesionFileManager: FileManagerFactoryMethod
    {
        private IFileManager _fileManager;
        public LogExtesionFileManager(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public override IFileManager GetFileManager()
        {
            return _fileManager;
        }
    }
}
