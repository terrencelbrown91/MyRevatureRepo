using System;
//using linq;

namespace Rock_Paper_SissorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////get input for the user
            //Console.WriteLine("Welcome to Rock-Paper-Sissors Game");
            //Console.WriteLine("Please enter r for Rock p for Papper s for Sissors ");
            ////char userInput = (char)Console.Read();
            //string userInput = Console.ReadLine();
            //Console.WriteLine(userInput);

            ////validate the use input as a 1, 2, or 3
            //int convertedNumber = -1;
            //bool conversionBool = false;

            //while (!conversionBool)
            //{
            //    conversionBool = Int32.TryParse(userInput, out convertedNumber);
            //    if (conversionBool)
            //    {
            //        if(convertedNumber > 0 && convertedNumber < 4)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hey, buddy... that was not a 1 or 2 or 3!\nPlease enter 1 for rock 2 for Paper or 3 for Scissors");
            //            userInput = Console.ReadLine();
            //        }

            //    }
            //}Console.WriteLine($"The int converted value inputed is {convertedNumber}");
            /* if (conversionBool == true)
             {
                 Console.WriteLine("The conversion from {userInput} to {convertedNumber} was successful. ");
             }
             else
             {
                 Console.WriteLine($"The conversion from the string {userInput} to {convertedNumber} was not successful.");
             } */

            //validate the use input as a 1, 2, or 3
            int convertedNumber = -1;
            bool conversionBool = false;
            int games = 3;
            for (int i = 0; i < games; i++)
            {

                do
                {
                    Console.WriteLine("Welcome to Rock-Paper-Sissors Game");
                    Console.WriteLine("Please enter 1 for Rock 2 for Papper 3 for Sissors ");
                    //char userInput = (char)Console.Read();
                    string userInput = Console.ReadLine();
                    Console.WriteLine(userInput);

                    conversionBool = Int32.TryParse(userInput, out convertedNumber);
                    if (!conversionBool || convertedNumber < 1 || convertedNumber > 3)
                    {
                        Console.WriteLine("Hey, buddy ... that was not a 1 or 2 or 3!");

                    }
                    else
                    {
                        break;
                    }
                } while (!(convertedNumber < 0 && convertedNumber < 4));

                Random ranNum = new Random();
                int comRand = ranNum.Next(1, 4);
                Console.WriteLine(comRand);
                //int comRan = Console.WriteLine(ranNum.Next(1, 4));

                if (convertedNumber == 3 && comRand == 1)
                {
                    Console.WriteLine("rock beats paper. computer wins!");
                }

                if (convertedNumber == 2 && comRand == 3)
                {
                    Console.WriteLine("Sissors beats Paper. Computer Wins!");
                }


                if (convertedNumber == 1 && comRand == 3)
                {
                    Console.WriteLine("Rock beats Sissor. Computer Wins");
                }

                if (convertedNumber.Equals(comRand))
                {
                    Console.WriteLine("tie match!");
                }



            }
        }
    }
}