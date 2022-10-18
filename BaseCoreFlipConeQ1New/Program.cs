namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int power = 1;
            Console.WriteLine("Please Enter Your Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            while (i <= num)
            {
                power = 2 * power;
                Console.WriteLine(power);
                i++;
            }
        }
    }
}