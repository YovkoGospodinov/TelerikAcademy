using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (0 < score && score < 10)
            {
                switch (score)
                {
                    case 1:
                    case 2:
                    case 3:
                        score *= 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        score *= 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        score *= 1000;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
