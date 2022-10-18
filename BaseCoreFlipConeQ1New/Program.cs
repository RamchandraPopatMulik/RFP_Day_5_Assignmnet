namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        public static bool isPrime(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(String[] args)
        {
            Program u = new Program();
            Console.WriteLine("Enter the no. to find PrimeFactors:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The prime factors for the " + n + " is:");

            for (int i = 2; i <= n; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}