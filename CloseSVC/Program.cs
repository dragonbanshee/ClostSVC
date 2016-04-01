using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CloseSVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] svc = Process.GetProcessesByName("client32");
            foreach (Process process in svc)
            {
                Console.WriteLine("Killing process with PID " + process.Id);
                process.Kill();
            }
            Console.WriteLine("Process(s) killed successfully");
            Console.ReadLine();

        }
    }
}
