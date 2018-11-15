using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHello
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage1());
        }
        public static string CreateMessage1()
        {
            return "hello world";
        }
        public static string CreateMessage2()
        {
            return "hello india";
        }
    }
}
