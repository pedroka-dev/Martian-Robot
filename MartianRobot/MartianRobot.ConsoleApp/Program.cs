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
        private static void ShowMovementStringText()
        {
            Console.WriteLine("Enter the movement string. Multiple characters required.");
            Console.WriteLine(" - E = Rotate left");
            Console.WriteLine(" - D = Rotate right");
            Console.WriteLine(" - M = Move ahead");
        }

        private static void ShowFacingDirectionText()
        {
            Console.WriteLine("Enter the intial robot facing direction. ");
            
        }

        private static void ShowInitialPositionText()
        {
            Console.WriteLine("Enter the intial robot X position, Y position and the facing direction direction (Formula = X Y Direction):");
            Console.WriteLine(" - X and Y must be a positive integer number smaller than the grid width.");
            Console.WriteLine(" - Direction N = North");
            Console.WriteLine(" - Direction S = South");
            Console.WriteLine(" - Direction L = East");
            Console.WriteLine(" - Direction O = West.");
        }

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

                Console.WriteLine("Enter the size of the the movement grid. (Formula = X Y):");

                string gridArea = Console.ReadLine();
                string[] splitGridArea = gridArea.Split(' ');

                if(splitGridArea.Length != 2)
                {
                    ShowErrorText("Error: Invalid number of arguments Try again with the Formula = X Y.");
                    continue;
                }

                if (!int.TryParse(splitGridArea[0], out int gridWidth) || gridWidth <= 0)
                {
                    ShowErrorText("Error: Invalid grid width value! Try again with a integer number bigger than zero.");
                    continue;
                }

                if (!int.TryParse(splitGridArea[1], out int gridHeight) || gridHeight <= 0)
                {
                    ShowErrorText("Error: Invalid grid height value! Try again with a integer number bigger than zero.");
                    continue;
                }

                Console.WriteLine($"@=@=@=@=@=@=@=@=@ GRID = {gridWidth}x{gridHeight} @=@=@=@=@=@=@=@=@");


                ShowInitialPositionText();
                string initialPosition = Console.ReadLine();
                string[] splitInitialPosition = initialPosition.Split(' ');

                if (splitInitialPosition.Length != 3)
                {
                    ShowErrorText("Error: Invalid number of arguments. Try again with the Formula = X Y Direction.");
                    continue;
                }

                if (!int.TryParse(splitInitialPosition[0], out int initialX) || initialX < 0)
                {
                    ShowErrorText("Error: Invalid initial X Position! Try again with a positive integer number.");
                    continue;
                }

                if (!int.TryParse(splitInitialPosition[1], out int initialY) || initialY < 0)
                {
                    ShowErrorText("Error: Invalid initial X Position! Try again with a positive integer number.");
                    continue;
                }

                string initialDirection = splitInitialPosition[2].ToUpperInvariant();

                if (initialDirection != "N" && initialDirection != "S" && initialDirection != "L" && initialDirection != "O")
                {
                    ShowErrorText("Error: Invalid operation type! Try again with a valid option.");
                    continue;
                }


                Robot robot = new Robot(initialX, initialY, initialDirection);
                Console.WriteLine("New robot initialized with values:" + robot.AtributesToString());
                ShowMovementStringText();
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
                            robot.moveAhead(gridWidth, gridHeight);
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
                if (Console.ReadLine().ToUpperInvariant() != "Y")
                    break;
            }
        }
    }
}
