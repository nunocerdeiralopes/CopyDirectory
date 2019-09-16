using System;
using System.IO;

namespace CopyDirectoryBLL
{
    public delegate void CopyingHandler(string message);
    public class CopyFunctions
    {
        public event CopyingHandler FileUpdate;
        public string CopyDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                if (source.FullName.ToLower() == target.FullName.ToLower())
                {
                    return "Same directory";
                }

                if (Directory.Exists(target.FullName) == false)
                {
                    Directory.CreateDirectory(target.FullName);
                }

                foreach (FileInfo fi in source.GetFiles())
                {
                    FileUpdate?.Invoke(string.Format(@"Copying {0}\{1}.", target.FullName, fi.Name));
                    fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
                    FileUpdate?.Invoke(string.Format(@"Copied {0}\{1} successfully.", target.FullName, fi.Name));
                }

                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyDirectory(diSourceSubDir, nextTargetSubDir);
                }


                return "Success";
            }
            catch(Exception ex)
            {
                FileUpdate?.Invoke(ex.Message);
                return "Error";
            }
        }
    }
}
