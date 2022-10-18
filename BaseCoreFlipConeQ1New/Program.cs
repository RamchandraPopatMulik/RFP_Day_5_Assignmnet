namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int temp;
            Console.WriteLine("Enter Your First Number :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Second Number :");
            int b = Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Value of a After Swaping :" + a);
            Console.WriteLine("Value of b After Swaping :" + b);
        }
    }
}