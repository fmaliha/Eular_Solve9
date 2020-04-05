using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prithagoreantriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int s = 1000;

            for (int a = 1; a < (s/3); a++)
            {
                for (int b = a; b < (s/2); b++)
                {
                   int c = s - a - b;

                      if (((a * a) + (b * b)) == (c * c))
                    {
                        Console.WriteLine("{0} ,{1}, {2}", a, b, c);
                        Console.WriteLine("the product is: {0}", a*b*c);

                    }


                }
            }
            Console.ReadKey();
                
            }
            
           
          
        }

         
    }

