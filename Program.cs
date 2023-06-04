namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int tiv  = Convert.ToInt32(Console.ReadLine());
        int tiv2 = tiv;
        int tiv3 = tiv;
        int count = 0;
        int verj = 0;
        while (tiv != 0)
            {
                int mnac;
                mnac = tiv % 10;
                tiv = tiv / 10;
                count++;
            }
          while (tiv2 != 0)
          {
                int mnac1;
                mnac1 = tiv2 % 10;
                tiv2 = tiv2 / 10;
                int b = 1;
                for (int i = 0; i < count; i++)
                {
                    b = b * mnac1;
                }
                verj = verj + b;
          }
      
          if (verj == tiv3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}