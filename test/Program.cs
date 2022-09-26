using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsoszam = int.Parse(Console.ReadLine());
            int masodikszam = int.Parse(Console.ReadLine());
            if (elsoszam > masodikszam)
            {
                Console.WriteLine(elsoszam);
            }
            else
            {
                Console.WriteLine(masodikszam);
            }
            Console.ReadKey();
        }  
    }
}
