using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle FirstRectangle = new Rectangle(3, 4.5);
            double result = FirstRectangle.Area();

            Console.WriteLine("The Area of 3 X 4.5 is: "
                  + result);
        }
    }
}
