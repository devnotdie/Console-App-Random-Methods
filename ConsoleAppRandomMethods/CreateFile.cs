using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace ConsoleAppRandomMethods
{
    class CreateFile
    {
       static StreamWriter streamWriter;
       // static StreamReader streamReader;
        static public void WriteToFile(string nameFilePath, string[] arr)
        {
            streamWriter = new StreamWriter(nameFilePath);
            foreach (var item in arr)
            {
                streamWriter.WriteLine(item);
            }
            streamWriter.Close();

            Process.Start(nameFilePath);
          
            Environment.Exit(0);
        }
        

    }
}
