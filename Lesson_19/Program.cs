using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "А666ХС126";
            string range = "[АВЕКМНОРСТУХ]";
            string pattern = $@"^{range}{{1}}\d{{3}}{range}{{2}}\d{{3}}$";

            var check = Regex.IsMatch(test, pattern);
            Console.WriteLine(check);
        }
    }
}
