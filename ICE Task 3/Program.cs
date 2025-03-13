namespace ICE_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle("Rectangle", 12, 10);
            Circle c = new Circle("Circle", 14);

            r.Display();
            Console.WriteLine();
            c.Display();
        }
    }
}
