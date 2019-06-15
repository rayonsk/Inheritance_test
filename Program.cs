using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_test
{
    class rectangle
    {
        protected double length;
        protected double breadth;
        protected double area;
        public rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }

        public double getArea()
        {
            area = length * breadth;
            return area;
        }
        public void display()
        {
            Console.WriteLine(" the length is {0}", length);
            Console.WriteLine(" the breadth is {0}", breadth);
            Console.WriteLine(" the area is {0}", getArea());
        }
    }
    class table : rectangle
    {
        public double cost;
        public table(double l, double b) : base(l, b)
        {

        }

        public double getCost()
        {
           double area = getArea();
           cost = area * 20;
           return cost; 
        }
        // area calculation done here to show that variables can be taken from the base class as its own. 
        public double getAreaWithoutBase()
        {
            area = length * breadth;
            return area;
        }
        public double getCostWithoutBaseArea()
        {
            double area = getAreaWithoutBase();
            cost = area * 20;
            return cost;
        }
        // end

        public void display()
        {
            base.display();
            Console.WriteLine("the cost is {0}", getCost());
            Console.WriteLine("the costWithout base area is {0}", getCostWithoutBaseArea());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           table obj = new table(2.5, 7.8);
            obj.display();
            Console.ReadLine();
        }
    }
}
