using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("не верно");
                if (a == "exit") 
                {
                    break;
                }
            }
        }
    }
}
