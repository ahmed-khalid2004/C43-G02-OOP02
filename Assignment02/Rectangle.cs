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
                if (value < 0)Console.WriteLine("Width cannot be negative.");
                else width = value; 
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)Console.WriteLine("Height cannot be negative.");
                else height = value;
            }
        }
        public double Area
        {
            get { return width * height; }
        }
        public void Display()
        {
            Console.WriteLine($"Rectangle dimensions: Width = {width}, Height = {height}, Area = {Area}");
        }
    }
}
