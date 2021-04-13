using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MartianRobot.ConsoleApp
{
    class Program
    {
        private static void ShowErrorText(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("@=@=@=@=@=@=@=@=@ MARTIAN ROBOT @=@=@=@=@=@=@=@=@");

                Console.WriteLine("Enter the width of the movement grid:");
                int gridWidth;
                if (!int.TryParse(Console.ReadLine(), out gridWidth) || gridWidth <= 0)
                {
                    ShowErrorText("Error: Invalid grid width value! Try again with a integer number bigger than zero.");
                    continue;
                }

                Console.WriteLine("Enter the height of the movement grid:");
                int gridHeight;
                if (!int.TryParse(Console.ReadLine(), out gridHeight) || gridHeight <= 0)
                {
                    ShowErrorText("Error: Invalid grid height value! Try again with a integer number bigger than zero.");
                    continue;
                }

                Console.WriteLine($"@=@=@=@=@=@=@=@=@ GRID = {gridWidth}x{gridHeight} @=@=@=@=@=@=@=@=@");


                Console.WriteLine("Enter the intial robot X position.");
                Console.WriteLine(" - Must be a positive integer number smaller than the grid width.");
                int initialX; 
                if(!int.TryParse(Console.ReadLine(), out initialX) || initialX < 0)
                {
                    ShowErrorText("Error: Invalid initial X Position! Try again with a positive integer number.");
                    continue;
                }


                Console.WriteLine("Enter the intial robot Y position. ");
                Console.WriteLine(" - Must be a positive integer number smaller than the grid height.");
                int initialY;
                if (!int.TryParse(Console.ReadLine(), out initialY) || initialY < 0)
                {
                    ShowErrorText("Error: Invalid initial X Position! Try again with a positive integer number.");
                    continue;
                }

                Console.WriteLine("Enter the intial robot facing direction. ");
                Console.WriteLine(" - N = North");
                Console.WriteLine(" - S = South");
                Console.WriteLine(" - L = East");
                Console.WriteLine(" - O = West.");
                string initialDirection = Console.ReadLine().ToUpperInvariant();

                if (initialDirection != "N" && initialDirection != "s" && initialDirection != "L" && initialDirection != "O")
                {
                    ShowErrorText("Error: Invalid operation type! Try again with a valid option.");
                    continue;
                }

                Robot robot = new Robot(initialX, initialY, initialDirection);
                Console.WriteLine("New robot initialized with values:" + robot.AtributesToString());


                Console.WriteLine("Enter the movement string. Multiple characters required.");
                Console.WriteLine(" - E = Rotate left");
                Console.WriteLine(" - D = Rotate right");
                Console.WriteLine(" - M = Move ahead");
                string movementString = Console.ReadLine();

                foreach (char c in movementString.ToUpperInvariant())
                {
                    Thread.Sleep(500);
                    switch (c)
                    {
                        case 'E':
                            robot.rotateLeft();
                            break;
                        case 'D':
                            robot.rotateRight();
                            break;
                        case 'M':
                            robot.moveAhead(gridWidth,gridHeight);
                            break;
                        default:
                            Console.WriteLine("Invalid character. Ignoring... ");
                            break;
                    }
                    Console.WriteLine("Robot current position:" + robot.AtributesToString());
                }


                Console.WriteLine("@=@=@=@=@=@=@=@=@  @=@=@=@=@=@=@=@=@");
                Console.WriteLine("Robot final position:" + robot.AtributesToString());
                Console.WriteLine("Do you want to initialize a robot? \n  Y - Yes\n  Any other key - Exit");
                if(Console.ReadLine().ToUpperInvariant() != "Y")
                    break;
            }
        }
    }
}
