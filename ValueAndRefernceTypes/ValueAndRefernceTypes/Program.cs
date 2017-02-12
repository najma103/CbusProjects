using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndRefernceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneInt = { 7};
            Console.WriteLine("Before: " + oneInt[0]);
            testInt(oneInt);
            Console.WriteLine("After calling test method: " + oneInt[0]);
        }
        static void testInt(int[] myInt)
        {
            myInt[0] = 10;
        }
    }
}
