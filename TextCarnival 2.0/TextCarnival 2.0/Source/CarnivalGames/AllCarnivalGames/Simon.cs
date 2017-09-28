using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnival_2._0.Source.CarnivalGames.AllCarnivalGames
{
    class Simon
    {
        public abstract string getName()
        {
            return "Simon";
        }
        public abstract void play()
        {
            showTitle("WELCOME TO SIMON");
            writeLine("This version of simon is based off of sounds");
            writeLine("There are 4 different sounds and you should return them in the order you hear them");
            writeLine("return the correct order 5 times and you win!");
            writeLine("Here are the 4 different sounds youll hear");

            beep(100);
            wait(1);
            beep(300, 1);
            wait(1);
            beep(600);
            wait(1);
            beep(900, 1);

            writeLine("each sound is assigned to a number 1-4");
            writeLine("1 is"); beep(100);
            writeLine("2 is"); beep(300, 1);
            writeLine("3 is"); beep(600);
            writeLine("4 is"); beep(900, 1);

            for (int i = 0; i < 5; i++)
            {
                if () { }
                if () { }
                if () { }
                if () { }
                
            }
        }
    }
}
