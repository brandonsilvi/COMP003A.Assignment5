using System;

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
                
            }
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
