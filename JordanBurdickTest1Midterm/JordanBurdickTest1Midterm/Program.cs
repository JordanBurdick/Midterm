using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanBurdickTest1Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            //part 1, infinite loop
            /*
            bool keepLooping = true;
            while (keepLooping == true)
            {
                Console.Write("I will never end. ");
            }
            */

            Console.WriteLine("== Part 2 ==");
            //part 2, 2-128 loop
            int i = 2;
            while (i <= 128)
            {
                Console.WriteLine("[{0}]", i);
                i *= 2;
            }

            Console.WriteLine("== Part 3 ==");
            //part 3 49 to 1 decrement single line with commas
            int j = 49;
            while (j >= 2)
            {
                Console.Write(j + ",");
                j--;
                //all this so there is no comma after one. probably a better way to go about it but oh well
                if (j == 2)
                {
                    Console.Write(j + ",");
                    j--;
                    Console.Write(j);
                  //  j--;
                }
            }
            Console.WriteLine("");

            Console.WriteLine("== Part 4 ==");
            //part 4 1 to 21 odd only and spaces
            int k = 1;
            while (k <= 21)
            {
                if (k % 2 ==0)
                {
                    //is even
                }
                else
                {
                    //is odd
                    Console.Write(k + " ");
                }
                k++;
            }
            Console.WriteLine("");

            Console.WriteLine("== Part 5 ==");
            //Console.WriteLine("");
            //part 5 do and do while loops
            /*
              the main difference between a do while and while is when it tests when the condition is true
              in a while loop it tests before executing, and in a do while it tests after executing.
             
            */
            int n = 8;
            int i2 = 10; //initialize
            do
            {
                Console.Write("*");
                i2++; //update!
            } while (i2 < n); //test condition

            while (i2 < n) //test condition
            {
                Console.Write("*");
                i2++; //update
            }

            Console.WriteLine("");
            Console.WriteLine("== Part 6 ==");
            //part 6  && and ||
            bool icyRain = false;
            bool tornadoWarning = false;
            Console.WriteLine("Icy rain: " + icyRain);
            Console.WriteLine("Tornado warning: " + tornadoWarning);
            if (icyRain == false && tornadoWarning == false)
            {
                Console.WriteLine("Lets go outside.");
            }
            if (icyRain == true || tornadoWarning == true)
            {
                Console.WriteLine("I liked it better indoors anyway.");
            }


            //part 7
            //hmmmm
            int a = 9;
            int b = 1;
            int c = 7;
            while (b <= c && b >= 1)
            {
                while (b <= c && c >= 1)
                {
                    if (b < c)
                    {
                        Console.Write(b);
                        b++;
                    }
                    else { 
                    Console.Write(b);
                    b--;
                         }
                    c--;
                }
                //c--;
                Console.WriteLine(" ");
            }

            //PLS
        }
    }
}
