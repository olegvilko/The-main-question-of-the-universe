using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_main_question_of_the_universe
{
    class Program
    {
        static protected void Print(double str)
        {
            Console.WriteLine(str);
        }

        static protected double GetSquare(int k)
        {
            return Math.Pow(k,2);
        }

        static void Main(string[] args)
        {
            Print(GetSquare(42));
        }
    }
}
