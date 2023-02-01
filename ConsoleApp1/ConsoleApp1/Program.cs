// See https://aka.ms/new-console-template for more information
using System;
using MyLib;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle(5);

            Console.WriteLine(cir.CalculateSquare());

            Triangle tr = new Triangle(3, 3, 3);

            Console.WriteLine(tr.isRightTriangle());
        }
    }
}