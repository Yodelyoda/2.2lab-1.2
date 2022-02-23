using System;

namespace _2._2lab_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("x = ");
            int x = Convert.ToInt32(Console.Read());
            Console.WriteLine("y = ");
            int y = Convert.ToInt32(Console.Read());
            // розгалуження в повній формі
            if ((y <= Math.Pow(-x, 2) + 2 && y <= x && y > 0) ||
                (y <= Math.Pow(-x, 2) + 2 && y >= x && y <= 0))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}
