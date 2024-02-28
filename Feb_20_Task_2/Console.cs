using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb_20_Task_2;

class Program
{
    static void Main(string[] args)
    {
        // -------------------------- Console Properties --------------------------------

        // 1. BackgroundColor

        /*  Illustration

            Console.WriteLine("Default Background Color: {0}", Console.BackgroundColor);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Changed Background Color: {0}", Console.BackgroundColor);
        */
        /*  List of available colors
        
        */
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine("List of available " + "Console Colors: ");
            foreach(var color in consoleColors)
                consoleColors.WriteLine(color);


        // Get the list of available colors 
        // that can be changed 
        ConsoleColor[] consoleColors 
            = (ConsoleColor[])ConsoleColor 
                  .GetValues(typeof(ConsoleColor)); 
  
        // Display the list 
        // of available console colors 
        Console.WriteLine("List of available "
                          + "Console Colors:"); 
        foreach(var color in consoleColors) 
            Console.WriteLine(color); 


        // 2. BufferHeight

        /*  Illustration
            Console.WriteLine("Default Buffer Height: {0}", Console.BufferHeight);
        */

        /*  Changing BufferHeight to 100
            Console.WriteLine("Default Buffer Height: {0}", Console.BufferHeight);
            Console.BufferHeight = 100;
            Console.WriteLine("Default Buffer Height: {0}", Console.BufferHeight);
        */

        
        //---------------------------- Console Methods ---------------------------

        /* 1. Beep()
                Console.Beep();
        */

        /* 2. Clear()
                Console.Clear();    
        */

       
        

    }
}
