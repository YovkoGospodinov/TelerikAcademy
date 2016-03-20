using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Carpets
{
    class Carpets
    {
        static void Main()
        {                       
            int n = int.Parse(Console.ReadLine());

            int elementOnLines = n;
            int center = elementOnLines / 2;

            for (int i = 1; i <= n / 2; i++)
            {
                int elPos = 1;
                while (elPos <= elementOnLines)
                {
                    if ((elPos <= center - i) || elPos > center + i)
                    {
                        Console.Write('.');
                        elPos++;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write('/');
                                elPos++;
                            }
                            else
                            {
                                Console.Write(' ');
                                elPos++;
                            }                                                        
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write('\\');
                                elPos++;
                            }
                            else
                            {
                                Console.Write(' ');
                                elPos++;
                            }                            
                        }
                    }                    
                }
                Console.WriteLine();
            }
            for (int i = n / 2; i > 0; i--)
            {
                int elPos = 1;
                while (elPos <= elementOnLines)
                {
                    if ((elPos <= center - i) || elPos > center + i)
                    {
                        Console.Write('.');
                        elPos++;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write('\\');
                                elPos++;
                            }
                            else
                            {
                                Console.Write(' ');
                                elPos++;
                            }                            
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write('/');
                                elPos++;
                            }
                            else
                            {
                                Console.Write(' ');
                                elPos++;
                            }
                        }
                    }                    
                }
                Console.WriteLine();

                //First idea y
                //int n = int.Parse(Console.ReadLine());

                //for (int i = 0; i < n / 2; i++)
                //{
                //    Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', (n / 2 - 1) - i), '/', new string(' ', 2 * i), '\\');
                //}

                //for (int i = 0; i < n / 2; i++)
                //{
                //    Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', i), '\\', new string(' ', n - 2 - 2 * i), '/');
                //}

                //second idea k
                //int N = int.Parse(Console.ReadLine());
                //int dots = (N / 2) - 1;
                //string leftSide = "/";
                //string downLeftSide = "\\";
                //string rightSide = "\\";
                //string downRightSide = "/";
                //int stringLength;

                //Console.Write(new string('.', dots));
                //Console.Write(leftSide);
                //Console.Write(rightSide);
                //Console.Write(new string('.', dots));
                //Console.WriteLine();
                //dots--;



                //for (int i = 0; i < (N / 2) - 1; i++)
                //{
                //    if (i % 2 == 0)
                //    {
                //        Console.Write(new string('.', dots) + leftSide + new string(' ', 2) + rightSide + new string('.', dots));
                //        dots--;
                //    }

                //    else
                //    {
                //        leftSide = leftSide + " /";
                //        rightSide = rightSide + " \\";
                //        Console.Write(new string('.', dots) + leftSide + rightSide);
                //        dots--;
                //    }
                //    Console.WriteLine();
                //}
                //dots = 0;
            }
        }
    }
}
