using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            long D = N / (3600 * 24);
            long H = N % (3600 * 24);
            long M = H / 60;
            long S = H % 60;

            if (H >= 24) H %= 24;
            if (M > 60) M %= 60;
            if (S > 60) S %= 60;

            Console.WriteLine("{0} {1} {2} {3}",D, H, M, S);
        }
    }
}
