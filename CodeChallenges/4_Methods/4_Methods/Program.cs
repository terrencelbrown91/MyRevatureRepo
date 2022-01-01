using System;


namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/


            

        }

        public static string GetName()
        {
            //throw new NotImplementedException("GetName() is not implemented yet0");
            
            Console.WriteLine("Please enter you name?");
            
            
            return Console.ReadLine();
            
        }

        public static string GreetFriend(string name)
        {
            //throw new NotImplementedException("GreetFriend() is not implemented yet");


           return $"Hello, {name}.  You are my friend.";
           
        }

        public static double GetNumber()
        {
            //throw new NotImplementedException("GetNumber() is not implemented yet");
            
            double myDouble1;
            double myDouble2;
            string userInput1;
            string userInput2;
            double totalDouble =0;
            do
            {
                userInput1 = Console.ReadLine();
                userInput2 = Console.ReadLine();

                if (double.TryParse(userInput1, out myDouble1) && double.TryParse(userInput2, out myDouble2))
                {
                   totalDouble = myDouble1 + myDouble2;
                }
            } while (!double.TryParse(userInput1, out myDouble1) && !double.TryParse(userInput2, out myDouble2));

            return totalDouble;
        }

        public static int GetAction()
        {
            throw new NotImplementedException("GetAction() is not implemented yet");
        }

        public static double DoAction(double x, double y, int action)
        {
            throw new NotImplementedException("DoAction() is not implemented yet");
        }

      
    }
}
