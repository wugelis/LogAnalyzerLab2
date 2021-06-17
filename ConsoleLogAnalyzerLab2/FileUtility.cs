using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab2
{
    public class FileUtility : IFileUtility
    {
        public bool CheckFileExists(string fileName)
        {
            return File.Exists(fileName);
        }
    }
}
