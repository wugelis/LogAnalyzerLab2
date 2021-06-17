using ConsoleLogAnalyzerLab2;

namespace ConsoleLogAnalyzerLab2Tests
{
    public class FakeFileUtility : IFileUtility
    {
        public bool CheckFileExists(string fileName)
        {
            return true;
        }
    }
}