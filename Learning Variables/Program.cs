using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Variables
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, What is your name?");
            //initializes variables. Can be left empty or blank
            string playerName = "";
            int playerScore = 0;

            playerName = Console.ReadLine();

            int add = 0;

            while (playerScore < 10) {
                Console.Write("Increment Score: ");
                add = Convert.ToInt32(Console.ReadLine());
            playerScore = playerScore + add;
            Console.Write("Current Score = ");
            Console.WriteLine(playerScore);
        }
           
            //Writes the lines and adds variables to code
            Console.WriteLine(playerName + " Wins!");
            
            //outputs the code
            Console.ReadLine();
        }
    }
}
