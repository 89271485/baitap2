using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle()
        {
            length = 1.0;
            width = 1.0;

        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;

        }
        public void setLength(double length)
        {
            this.length = length;

        }
        public double getLength()
        {
            return length;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getWidth()
        {
            return width;
        }
        public double FindArea()
        {
            return length * width;
        }
        public double FindPerimeter()
        {
            return (length + width) * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            Rectangle r2;

            r1 = new Rectangle();
            Console.Write("Cho biet chieu dai: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Cho biet chieu rong: ");
            double width = double.Parse(Console.ReadLine());

            r2 = new Rectangle(length, width);

            Console.WriteLine("--------Thong tin hinh chu nhat r1-------");
            Console.WriteLine("Chieu dai: {0}\n Chieu rong: {1}\n Dien tich: {2}\n Chu vi: {3}",
                r1.getLength(), r1.getWidth(), r1.FindArea(), r1.FindPerimeter());

            Console.WriteLine("--------Thong tin hinh chu nhat r2-------");
            Console.WriteLine("Chieu dai: {0}\n Chieu rong: {1}\n Dien tich: {2}\n Chu vi: {3}",
                r2.getLength(), r2.getWidth(), r2.FindArea(), r2.FindPerimeter());

            Console.ReadKey();
        }
    }
}
