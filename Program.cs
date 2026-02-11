using System;
using System.Security.Authentication.ExtendedProtection;

namespace COMP003A.Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            string runAgain = "y";
            
            //loop to repeat program execution
            while (runAgain.ToLower() == "y")
            {
                DisplayIntroduction();//call program intro method

                Console.Write("Enter your name: "); // establish username in main
                string userName = Console.ReadLine();

                Console.Write("Enter a whole number"); //establish usernumber in main
                int userNumber = int.Parse(Console.ReadLine());
                
                //send input to a method w/paramaters
                DisplayUserInfo(userName, userNumber);
                
                //use calculation method to multiply usernumber by 2 and store the returned value
                int calculatedResult = PerformCalculation(userNumber);
                Console.WriteLine($"Calculated result: {calculatedResult}");
                
                //Decision-making using the returned value
                if (calculatedResult > 10)
                {
                    Console.WriteLine("The result is greater than 10.");
                }
                else
                {
                    Console.WriteLine("The result is 10 or less.");
                }
                // Allow user to rune code again
                Console.Write("\nWould you like to run the program again? (y/n)");
                run again = Console.ReadLine();
                Console.WriteLine();
            }
            
            Console.WriteLine("Program ended.");
        }
        
        //methods section-----------------------------------
        //methods exists to improve organization. These can be used as tools to call in the main
        //to produce a specific action when called without having to retype the instructions for the action
        static void DisplayIntroduction()  //method to display introduction
        {
            Console.WriteLine("Welcome to the Program Organizer!\n");
        } /*this method reduces clutter in main by allowing for the call of the method to display
        the console writeline*/

        static void DisplayUserInfo(string name, int number) //method with paramaters: name and age
        { //Method shows that its variables are seperate from the main
            Console.WriteLine($"\nHello, {name}! you entered the number: {number}");
        }
        static int PerformCalculation(int num) //method to perform a calc and return value
        { //returns the input * 2 
            return num * 2;
        }
        
      
    }
}
