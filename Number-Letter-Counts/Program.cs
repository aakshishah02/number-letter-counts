using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Letter_Counts
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber;
            int letterCount = 0;

            Console.WriteLine("Please enter the number to calculate");
            enteredNumber = Convert.ToInt32(Console.ReadLine());
            if (enteredNumber > 0 && enteredNumber <= 1000)
            {
                for (int i = 1; i <= enteredNumber; i++)
                {

                    if (i < 10)
                        letterCount += Sum_1_To_9(i - 1);
                    else if ((i >= 10) && (i < 20))
                        letterCount += Sum_10_To_19(i % 10);
                    else if (((i % 10) == 0) && (i >= 20) && (i < 100))
                        letterCount += Sum_20_To_90_Only10s(i / 10 - 2);
                    else if (((i % 10) != 0) && (i >= 20) && (i < 100))
                    {
                        letterCount += Sum_20_To_90_Only10s(i / 10 - 2);
                        letterCount += Sum_1_To_9(i % 10 - 1);
                    }
                    else if (((i % 100) == 0) && (i < 1000))
                        letterCount += Sum_100_To_900_Only100s(i / 100 - 1);
                    else if ((i > 100) && ((i % 100) != 0) && (i < 1000))
                    {
                        letterCount += Sum_100_To_900_Only100s((i / 100) - 1);
                        letterCount += Sum_And();
                        if ((i % 100) < 10)
                            letterCount += Sum_1_To_9((i % 100) - 1);
                        else if (((i % 100) >= 10) && ((i % 100) < 20))
                            letterCount += Sum_10_To_19((i % 100) % 10);
                        else if ((((i % 100) % 10) == 0) && ((i % 100) >= 20) && ((i % 100) < 100))
                            letterCount += Sum_20_To_90_Only10s((i % 100) / 10 - 2);
                        else if ((((i % 100) % 10) != 0) && ((i % 100) >= 20) && ((i % 100) < 100))
                        {
                            letterCount += Sum_20_To_90_Only10s((i % 100) / 10 - 2);
                            letterCount += Sum_1_To_9((i % 100) % 10 - 1);
                        }
                        else if ((((i % 100) % 100) == 0) && ((i % 100) < 1000))
                            letterCount += Sum_100_To_900_Only100s((i % 100) / 100 - 1);
                    }
                    else if (i == 1000)
                        letterCount += Sum_1000();
                }
                Console.WriteLine("Result is {0}", letterCount);

            }
            else
            {
                Console.WriteLine("Invalid Number ");
            }

            Console.ReadKey(); ;

        }

        private static int Sum_1_To_9(int i)
        {
            int[] One_To_Nine = new int[] { 3, 3, 5, 4, 4, 3, 5, 5, 4 };
            return One_To_Nine[i];
        }

        private static int Sum_10_To_19(int i)
        {
            int[] Ten_To_Nineteen = new int[] { 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
            return Ten_To_Nineteen[i];
        }

        private static int Sum_20_To_90_Only10s(int i)
        {
            int[] Twenty_To_Ninety = new int[] { 6, 6, 5, 5, 5, 7, 6, 6 };
            return Twenty_To_Ninety[i];
        }

        private static int Sum_100_To_900_Only100s(int i)
        {
            int[] OneHundred_To_NineHundred = new int[] { 10, 10, 12, 11, 11, 10, 12, 12, 11 };
            return OneHundred_To_NineHundred[i];
        }

        private static int Sum_1000()
        {
            int Sum_1000 = 11;
            return Sum_1000;
        }

        private static int Sum_And()
        {
            int Sum_And = 3;
            return Sum_And;
        }


    }
}
