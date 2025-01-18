using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Rectangle
    {
        private double width;
        private double height;
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)Console.WriteLine("Width should not be negative.");
                else width = value; 
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)Console.WriteLine("Height should not be negative.");
                else height = value;
            }
        }
        public double Area
        {
            get { return width * height; }
        }
        public void Display()
        {
            Console.WriteLine($"Width = {width}, Height = {height}, Area = {Area}");
        }
    }
}
