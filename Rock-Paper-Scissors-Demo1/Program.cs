﻿using System;
//new update
namespace Rock_Paper_Scissors_Demo1
{
	class Program
	{
		static void Main(string[] args)
		{
			//get input form the user
			Console.WriteLine("Hello. Welcome to Rock-Paper-Scissors Game!");
			//Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
			//string userInput = Console.ReadLine();
			//Console.WriteLine(userInput);

			////validate the use input as a 1, 2, or 3
			////instantiate a int type variable.
			//int convertedNumber = -1;
			//bool conversionBool = false;

			//while (conversionBool == false)
			//{
			//	conversionBool = Int32.TryParse(userInput, out convertedNumber);
			//	if (conversionBool)
			//	{
			//		if (convertedNumber > 0 && convertedNumber < 4)
			//		{
			//			break;
			//		}
			//		else
			//		{
			//			Console.WriteLine("Hey, buddy... that wasn't a 1 or 2 or 3!\nPlease enter a 1 for ROCK, 2 for PAPER, or 3 for SCISSORS");
			//			userInput = Console.ReadLine();
			//		}
			//	}
			//}

			int convertedNumber = -1;
			bool conversionBool = false;
			do
			{
				Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
				string userInput = Console.ReadLine();
				//Console.WriteLine(userInput);

				//validate the use input as a 1, 2, or 3
				//this version of TryParse() takes a string and the second argument is an out variable that is instantiated in that moment.
				conversionBool = Int32.TryParse(userInput, out convertedNumber);
				if (!conversionBool || convertedNumber < 1 || convertedNumber > 3)
				{
					Console.WriteLine("Hey, buddy... that wasn't a 1 or 2 or 3!");
				}

			} while (!(convertedNumber > 0 && convertedNumber < 4));
			//Console.WriteLine($"The int converted value inputted is {convertedNumber}");

			Random randNum = new Random();
			Console.WriteLine(randNum.Next(1, 4));// inclusive of the first (lower) value and exclusive of hte second(upper) value. 

			/**homework - 
			 * 1. get a random number for the computer
			 * 2. compare who won the round
			 * 3. refactor the code to have a best of three game
			 * 4. print out the winner, and how many games were won by each (and ties)
			 * 5. and exit the program.
			 * 
			 * 
			 * 
			 * 
			**/




		}
	}
}
