using System;

namespace Task_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введіть довжину першої сторони: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть довжину другої сторони: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            
            Rectangle rectangle = new Rectangle(side1, side2);
            
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        }
    }
}