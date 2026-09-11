using System;
using System.IO;

namespace BlaisePascal.SmartSchoolApp.Infrastructure
{
    public class LocalPathHelper
    {
        public static string GetSolutionRoot()
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            while (dir != null && !Directory.Exists(Path.Combine(dir.FullName, "Src")))
            {
                dir = dir.Parent;
            }

            if (dir == null)
                throw new Exception("Solution root not found");
            return dir.FullName;
        }
    }
}
