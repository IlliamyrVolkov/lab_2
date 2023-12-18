namespace Task_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(0, 1, "B");
            Point point3 = new Point(1, 0, "C");
            
            Figure triangle = new Figure(point1, point2, point3);

            triangle.CalculatePerimeter();
        }
    }
}