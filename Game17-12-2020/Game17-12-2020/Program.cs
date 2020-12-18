using System;

namespace Game17_12_2020
{
    class Program
    {
        static void Main(string[] args)

        {
            int userInput1;
            int FirstUserPoint = 10;
            int SecondUserPoint = 10;
            do
            {

               
                Console.WriteLine("Tas - 1   ||  Kagiz -2  ||  Makas -3  || Exit  - 0 ");
               
                 userInput1 = Convert.ToInt32(Console.ReadLine());
                if (userInput1 != 0)
                {
                      Console.Clear();
                      Console.WriteLine("Tas - 1   ||  Kagiz -2  ||  Makas -3  || ");
                      int userInput2 = Convert.ToInt32(Console.ReadLine());
                      Console.Clear();



                    if (userInput1 == 1)
                    {
                        if (userInput2 == 1)
                        {
                            Console.WriteLine("Tas , Tas - Beraber ");

                        }
                        else if (userInput2 == 2)
                        {
                            Console.WriteLine("Tas uduzdu , Kagiz uddu ");
                        }
                        else if (userInput2 == 3)
                        {
                            Console.WriteLine("Tas uddu  , makas uduzdu");
                        }
                        else
                        {
                            Console.WriteLine("Daxil edilen reqemler 1-3 araliginda olmalidir :");
                        }
                    }
                    else if (userInput1 == 2)
                    {
                        if (userInput2 == 1)
                        {
                            Console.WriteLine("Kagiz uddu , Tas uduzdu ");
                        }
                        else if (userInput2 == 2)
                        {
                            Console.WriteLine("Kagiz  , Kagiz - Beraber");
                        }
                        else if (userInput2 == 3)
                        {
                            Console.WriteLine("Kagiz uduzdu  ,  Makas uddu ");
                        }
                        else
                        {
                            Console.WriteLine("Daxil edilen eded 1-3 araliginda olmalidir ");
                        }
                    }
                    else if (userInput1 == 3)
                    {
                        if (userInput2 == 1)
                        {
                            Console.WriteLine("Makas uduzdu , Tas uddu ");
                        }
                        else if (userInput2 == 2)
                        {
                            Console.WriteLine("Makas uddu , Kagiz uduzdu ");
                        }
                        else if (userInput2 == 3)
                        {
                            Console.WriteLine("Makas  , Makas - beraberlik");
                        }

                    }
                   Console.ReadKey();
                  //  Console.ReadLine();
                }
            } while (userInput1 != 0);

            

    








        }
    }
}
