namespace Figure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[]
            {
                new Point(1, 3, "A"),
                new Point(2, -5, "B"),
                new Point(-2, -3, "C"),
                new Point(4, 5, "D"),
            };

            Figure figure = new Figure(points);
            figure.PerimeterCalculator();
        }
    }
}