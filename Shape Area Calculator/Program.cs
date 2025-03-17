namespace Shape_Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the name of the shape");
            string name = Console.ReadLine();
            if (name == "Circle")
            {
                Console.WriteLine("Give me it's radius");
                double radius = double.Parse(Console.ReadLine());
            }
        }
    }
}
