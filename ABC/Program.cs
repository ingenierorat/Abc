using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int abc = 'a'; abc <= 'z'; abc++)
            {
                Console.WriteLine((char)abc+"*");
            }
            Console.ReadKey();
        }
    }
}
