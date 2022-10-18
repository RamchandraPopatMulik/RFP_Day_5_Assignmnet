namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0.0;
            Console.WriteLine("Please Enter Your Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                s += 1 / (float)i;
            }
            Console.WriteLine("Harmonic Series is :" + s);
        }
    }
}