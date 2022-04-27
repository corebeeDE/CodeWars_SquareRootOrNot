using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_SquareRootOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/57f6ad55cca6e045d2000627/
        }

        // First solution
        public static int[] SquareOrSquareRoot(int[] array)
        {
            return array.Select(x => int.TryParse(Math.Sqrt(x).ToString(), out int result) ? result : x * x).ToArray();
        }
    }
}
