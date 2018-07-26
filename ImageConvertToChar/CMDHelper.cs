using System.Diagnostics;
using System.IO;

namespace ImageConvertToChar
{
    class CMDHelper
    {
        public static string ExcuteCmd(string cmd)
        {
            string output = "";
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardInput = true;
                process.Start();
                process.StandardInput.AutoFlush = true;
                process.StandardInput.WriteLine(cmd);
                process.StandardInput.WriteLine("exit");
                process.StandardInput.Close();
                output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
            return output;
        }
    }
}
