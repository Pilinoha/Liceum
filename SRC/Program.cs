using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strur
{
    class Program
    {
        static Double y(Double x)
        {
            Double x2 = x*x;
            return 3.0 * x2 * x2 + 14.0 * x2 * (x - 3.0) - 5.0 * (x - 3.0) * (x - 3.0);
        }
        static void Main(string[] args)
        {
            Double x;
            for (x = -7.111; x < -7.108; x += 0.0005)
                Console.WriteLine("{0,8:F4} {1,8:F4}     y={2,8:F3}", x, y(x), x * x / (x - 3.0));
            Console.WriteLine();
            for (x = 2.109; x < 2.11101; x += 0.0005)
                Console.WriteLine("{0,8:F4} {1,8:F4}     y={2,8:F3}", x, y(x), x * x / (x - 3.0));
            Double s34 = Math.Sqrt(34.0);
            Console.WriteLine("\n{0,8:F3} {1,8:F3} ", (-7.0 - s34) / 3.0, (-7.0 + s34) / 3.0);

        }
    }
}
