using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Simon : CarnivalGame
    {
        public override string getName()
        {
            return "Simon";
        }
        public override void play()
        {
            Random Rando = new Random();
            int rd1 = Rando.Next(1, 4);
            int rd2 = Rando.Next(1, 4);
            int rd3 = Rando.Next(1, 4);
            int rd4 = Rando.Next(1, 4);
            int rd5 = Rando.Next(1, 4);
            string Ans;
            bool isCorrect = false;

            showTitle("WELCOME TO SIMON");
            writeLine("This version of simon is based off of sounds");
            writeLine("There are 4 different sounds and you should return them in the order you hear them");
            writeLine("return the correct order 5 times and you win!");
            writeLine("Here are the 4 different sounds youll hear");

            beep(100, 1);
            wait(1);
            beep(300, 1);
            wait(1);
            beep(600, 1);
            wait(1);
            beep(900, 1);
            wait(1);

            writeLine("each sound is assigned to a number 1-4");
            writeLine("1 is"); beep(100, 1);
            writeLine("2 is"); beep(300, 1);
            writeLine("3 is"); beep(600, 1);
            writeLine("4 is"); beep(900, 1);

            
            if (rd1 == 1)
            {
                beep(100, 1);
            }
            if (rd1 == 2)
            {
                beep(300, 1);
            }
            if (rd1 == 3)
            {
                beep(600, 1);
            }
            if (rd1 == 4)
            {
                beep(900, 1);
            }

            writeLine("Enter your answer:");
            Ans = getInput();
            int s = Convert.ToInt32(Ans);

            if (s == rd1)
            {
                writeLine("Correct!");
                isCorrect = true;
            }
            else
            {
                writeLine("Wrong! You Lose!");
            }

           if(isCorrect == true)
            {
                if (rd2 == 1)
                {
                    beep(100, 1);
                }
                if (rd2 == 2)
                {
                    beep(300, 1);
                }
                if (rd2 == 3)
                {
                    beep(600, 1);
                }
                if (rd2 == 4)
                {
                    beep(900, 1);
                }

                writeLine("Enter your answer:");
                Ans = getInput();
                s = Convert.ToInt32(Ans);

                if (s == rd2)
                {
                    writeLine("Correct!");

                }
                else
                {
                    writeLine("Wrong! You Lose!");
                    isCorrect = false;
                }

            }
            if (isCorrect == true)
            {
                if (rd3 == 1)
                {
                    beep(100, 1);
                }
                if (rd3 == 2)
                {
                    beep(300, 1);
                }
                if (rd3 == 3)
                {
                    beep(600, 1);
                }
                if (rd3 == 4)
                {
                    beep(900, 1);
                }

                writeLine("Enter your answer:");
                Ans = getInput();
                s = Convert.ToInt32(Ans);

                if (s == rd3)
                {
                    writeLine("Correct!");

                }
                else
                {
                    writeLine("Wrong! You Lose!");
                    isCorrect = false;
                }

            }
            if (isCorrect == true)
            {
                if (rd4 == 1)
                {
                    beep(100, 1);
                }
                if (rd4 == 2)
                {
                    beep(300, 1);
                }
                if (rd4 == 3)
                {
                    beep(600, 1);
                }
                if (rd4 == 4)
                {
                    beep(900, 1);
                }

                writeLine("Enter your answer:");
                Ans = getInput();
                s = Convert.ToInt32(Ans);

                if (s == rd4)
                {
                    writeLine("Correct!");

                }
                else
                {
                    writeLine("Wrong! You Lose!");
                    isCorrect = false;
                }

            }
            if (isCorrect == true)
            {
                if (rd5 == 1)
                {
                    beep(100, 1);
                }
                if (rd5 == 2)
                {
                    beep(300, 1);
                }
                if (rd5 == 3)
                {
                    beep(600, 1);
                }
                if (rd5 == 4)
                {
                    beep(900, 1);
                }

                writeLine("Enter your answer:");
                Ans = getInput();
                s = Convert.ToInt32(Ans);

                if (s == rd5)
                {
                    writeLine("Correct!");
                }
                else
                {
                    writeLine("Wrong! You Lose!");
                    isCorrect = false;
                }

            }


        }
    }
}
    