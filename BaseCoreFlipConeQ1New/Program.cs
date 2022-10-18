namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please Enter Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend {0} Divisor {1}", dividend, divisor);

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}