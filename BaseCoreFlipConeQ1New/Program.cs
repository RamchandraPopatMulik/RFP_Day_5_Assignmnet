namespace BaseCoreFlipConeQ1New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coin Flip Count");
            double Toss = Convert.ToDouble(Console.ReadLine());
            int HCount = 0;
            int TCount = 0;
            for (int i = 0; i < Toss; i++)
            {
                Random random = new Random();
                int dice = random.Next(0, 2);
                if (dice < 0.5)
                {
                    HCount += 1;
                }
                else
                {
                    TCount += 1;
                }
                Console.WriteLine("Head Count : " + HCount);
                Console.WriteLine("Tail Count : " + TCount);
                double Hpercent = ((double)HCount / Toss) * 100;
                Console.WriteLine("Head Percentage is :" + Hpercent);
                double Tpercent = ((double)TCount / Toss) * 100;
                Console.WriteLine("Head Percentage is :" + Tpercent);
            }
        }
    }
}