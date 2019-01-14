using System;
using System.Diagnostics;

namespace ImageHijack
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool hasDoc = args.GetLength(0) > 2;
            string procToStart = args[0];

            string filePath = string.Empty;
            if (hasDoc)
            {
                for (int i = 2; i < args.GetLength(0); i++)
                {
                    if (i > 2)
                        filePath += " ";

                    filePath += args[i];
                }       
            }

            Process p = hasDoc ?
              Process.Start(procToStart, $"\"{filePath}\"")
              : Process.Start(procToStart); 
        }
    }
}