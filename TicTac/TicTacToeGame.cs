using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac
{
     class TicTacToeGame
    {
        

        public void Board()
        {
            string [] arr = new string [10];
            arr[0] = "";
            arr[1] = "";
            arr[2] = "";
            arr[3] = "";
            arr[4] = "";
            arr[5] = "";
            arr[6] = "";
            arr[7] = "";
            arr[8] = "";
            arr[9] = "";
        }
        public void  playersChoice()
        {
            Console.WriteLine("Enter Player1: X and Computer: O");
            string choice = Console.ReadLine();

            if (choice == "x") {
                Console.WriteLine("player1 chance");
               
                 }
            else if(choice == "o")
            {
                Console.WriteLine("computer chance");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            
        }
    }
}
