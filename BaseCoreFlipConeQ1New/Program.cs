namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine(" This is a Leap Year ");
            }
            else
            {
                Console.WriteLine(" This is a Not Leap Year ");
            }
        }
    }
}