﻿using ConsoleLogAnalyzerLab2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogAnalyzerLab1
{
    /// <summary>
    /// 分析 Log 格式是否符合規範
    /// </summary>
    public class LogAnalyzer
    {
        /// <summary>
        /// 檢核是否為有效的 Log 檔案名稱
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool IsValidLogFileName(string fileName)
        {
            IFileManager fileManager = new FileManager();
            fileManager.SetFileUtility = new FileUtility();

            LogExtesionFileManager stub = new LogExtesionFileManager(fileManager);

            return stub.IsValidLogFileName(fileName);
        }
    }
}
