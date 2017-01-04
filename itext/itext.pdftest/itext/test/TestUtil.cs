using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace iText.Test
{
    public static class TestUtil
    {
        public static String GetProjectDirectory(String testDirectory) {
            DirectoryInfo projectDirectoryInfo = new DirectoryInfo(testDirectory);
            while (!projectDirectoryInfo.Name.Equals("bin", StringComparison.OrdinalIgnoreCase)) {
                projectDirectoryInfo = projectDirectoryInfo.Parent;
            }
            return projectDirectoryInfo.Parent.FullName;
        }
    }
}
