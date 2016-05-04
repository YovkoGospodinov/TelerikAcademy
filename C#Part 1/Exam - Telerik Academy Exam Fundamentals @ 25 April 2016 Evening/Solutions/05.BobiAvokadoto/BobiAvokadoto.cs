using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BobiAvokadoto
{
    class BobiAvokadoto
    {
        static void Main(string[] args)
        {
            uint head = uint.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            uint bestComb = 0;
            int mostTeeth = 0;

            for (int i = 0; i < lines; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());
                //Console.WriteLine(Convert.ToString(head, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(comb, 2).PadLeft(32, '0'));
                int teeth = 0;
                if ((head & comb) == 0)
                {

                    for (int j = 0; j < 32; j++)
                    {
                        uint moved = comb & (1U << j);
                        //Console.WriteLine(Convert.ToString(moved, 2).PadLeft(32, '0'));
                        moved = moved >> j;
                        //Console.WriteLine(Convert.ToString(moved, 2).PadLeft(32, '0'));
                        if (moved == 1)
                        {
                            teeth++;
                        }
                    }

                }
                if (teeth > mostTeeth)
                {
                    mostTeeth = teeth;
                    bestComb = comb;
                }

            }
            Console.WriteLine(bestComb);
        }
    }
}
