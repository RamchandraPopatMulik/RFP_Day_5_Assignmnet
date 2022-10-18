namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please Enter Your Alphabats: ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            if (ch >= 48 && ch <= 57)
            {
                Console.WriteLine("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            }
        }
    }
}