using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandConsole
{
    public class CommandConsole
    {
        public string CurrentPath { get; private set; } = "C:";

        public void PrintCurrentPath()
        {
            Console.Write($"{CurrentPath}>");
        }
    }
}
