using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_test
{
    class Program
    {

        ////////////////  PROJECT   ///////////////
        //////////////// PING PONG  ///////////////
        //////////////// Use arrow  ///////////////
        ////////////////   keys     ///////////////

        static void Main(string[] args)
        {
            bool game = true;
            /*
            Console.WriteLine("Do you want to play the maze game?");
            Console.Write (" Y / N ");
            var userStart = Console.ReadLine();
            switch (userStart)
            {
                case "y":
                    game = true;                        
                    break;
                case "n":
                    game = false;
                    break;
                default:
                    break;
            }
            */

            int width = 40;
            int heigth = 12;

            Console.WriteLine("SOLID RECTANGLE");
            const int borderX = 0;
            const int borderY = -1;
            int xpos = 0; // Holds solid rectangles current position, manipulated by var userDir
            int ypos = 0; 

            // The while loop and switch case keeps a running track of position from user arrow key input
            while (game)
            {
                var userDir = Console.ReadKey(false).Key;
                switch (userDir) // If there is an input, update corresponding value
                {
                    case ConsoleKey.UpArrow:
                        if (ypos > 1)
                        {
                            ypos -= 1;
                        }
                        else
                        {
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (xpos < (width - 2))
                        {
                            xpos += 1;
                        }
                        else
                        {
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (ypos < (heigth - 2))
                        {
                            ypos += 1;
                        }
                        else
                        {
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (xpos > 1)
                        {
                            xpos -= 1;
                        }
                        else
                        {
                        }
                        break;
                    default:
                        break;
                }

                // After grabbing the input, call Clear to refresh the screen and                          
                Console.Clear();

                // Run code updating the new position, and print next frame. 
                // As we move down, the value of j increase
                for (int j = 0; j < heigth; j++)
                {
                    // As we move to the right, value of i increase
                    for (int i = 0; i < width; i++)
                    {
                        // Finally the coordinates!!! X & Y position!
                        if ((j == ypos  && i == xpos) && j != 0 )
                        {
                            Console.Write(" "); // Try swapping these
                        }                   
                        else
                        {
                            Console.Write("█"); // Try swapping these
                        }
                    }
                    Console.WriteLine(); // WriteLine at the end of for loop moves cursor to next "tile" in the console window 
                }
                Console.WriteLine(); // WriteLine at the end of for loop moves cursor to next "tile" in the console window 
            }

                /*
                 
                // Secondary style

              int borderW = 1;
              Console.WriteLine("BORDER RECTANGLE");

              // As we move down, the value of j increase
              for (int j = 0; j < heigth; j++)
              {
                  // As we move to the right, value of i increase
                  for (int i = 0; i < width; i++)
                  {
                      if (j < borderW || j > heigth - 1 - borderW || i < borderW || i > width - 1 - borderW)
                      {
                          Console.Write(" ");
                      }
                      else
                      {
                          Console.Write("█");
                      }
                  }
                  Console.WriteLine();
              }
              Console.WriteLine();

                // Anther secondary style
              Console.WriteLine("CHECKER PATTERN");
              // j and i will be location of pixel
              // if pixel is even, it should be off. 2, 4, 6

              // As we move down, the value of j increase
              for (int j = 0; j < heigth; j++)
              {

                  // As we move to the right, value of i increase
                  for (int i = 0; i < width; i++)
                  {
                      if ((j + i) % 2 == 0)
                      {
                          Console.Write(" ");
                      }
                      else
                      {
                          Console.Write("█");
                      }
                  }
                      Console.WriteLine();
              }
            Console.WriteLine();
            Console.ReadLine();

            */
        }

    }
}
