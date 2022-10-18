namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please Enter Your Number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("THIS IS EVEN NUMBER");
            }
            else
            {
                Console.WriteLine("THIS IS ODD NUMBER");
            }
        }
    }
}