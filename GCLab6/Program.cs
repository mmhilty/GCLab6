using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab6
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int diceSides;

            while (true)
            {
                Console.WriteLine("How many sides do your dice have?");
                
                diceSides = Convert.ToInt32(Console.ReadLine());

                int outsideDiceResult = ReturnDiceNum(diceSides, rnd);
                Console.WriteLine("You rolled a " + outsideDiceResult + ".");

                int outsideDiceResult2 = ReturnDiceNum(diceSides, rnd);
                Console.WriteLine("You rolled a " + outsideDiceResult2 + ".");

                //special message section

                if(outsideDiceResult == 1 && outsideDiceResult2 == 1)
                {
                    Console.WriteLine("Snake Eyes!");
                }

                else if(outsideDiceResult + outsideDiceResult2 == 2 || outsideDiceResult + outsideDiceResult2 == 3 || outsideDiceResult + outsideDiceResult2 == 12)
                {
                    Console.WriteLine("Oh no. You crapped out. I think. I have no idea what the rules of craps is. I'm not a 20s gangster.");
                }

                else if(outsideDiceResult == 6 && outsideDiceResult2 == 6)
                {
                    Console.WriteLine("Box cars!");
                }

                //continue section
                contSection:
                Console.WriteLine("Do you want to continue? y/n");
                string contInput = Console.ReadLine();

                if (contInput.ToLower() == "y")
                {
                    continue;
                }

                else if (contInput.ToLower() == "n")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Huh?");
                    goto contSection;
                }


                //int diceResult;

                // run the returnDiceNum function 2 times to print dice results  
            }
        }


        static int ReturnDiceNum(int diceSides, Random random)
        {
   
            int diceResult = random.Next(1, diceSides);
           
            return diceResult;

        }


        }

    }
