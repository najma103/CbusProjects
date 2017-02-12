using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Rectangle
    {
        private double lenght;
        private double width;

        // constructor
        public Rectangle(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        //method returns double value of the area. 
        public double Area()
        {
            return lenght * width;
        }
    }
    
}
