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
        }
        
      
    }
}
