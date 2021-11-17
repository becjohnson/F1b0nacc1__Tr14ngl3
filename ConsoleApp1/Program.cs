using System;
public class PrintExample
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Run();
        }
         void Run() {
            int a = 0, b = 1, i, c, n, j;
            Console.Write("Enter the limit: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");
                for (j = 1; j < i; j++)
                {
                    c = a + b;
                    Console.Write(c + "\t");
                    a = b;
                    b = c;
                }
                Console.Write("\n");
            }

            AnyKey();
        }

        void AnyKey()
        {
            Console.WriteLine("Press any key to run again..(try 369)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}