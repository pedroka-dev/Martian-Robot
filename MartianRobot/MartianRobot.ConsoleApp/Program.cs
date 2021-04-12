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

        static void Main(string[] args)
        {
            //1. inicializar grid
            //2. inicializar posicao do robo. posicao deve ser valida
            //3. mandar a string de movimento

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("@=@=@=@=@=@=@=@=@ MARTIAN ROBOT @=@=@=@=@=@=@=@=@");

            Console.WriteLine("Enter the width of the movement grid:");
            string gridWidth = Console.ReadLine();

            Console.WriteLine("Enter the height of the movement grid:");
            string gridHeight = Console.ReadLine();

            Console.WriteLine($"@=@=@=@=@=@=@=@=@ GRID = {gridWidth}x{gridHeight} @=@=@=@=@=@=@=@=@");


            
            while (true)
            {
                Console.WriteLine("Enter the intial robot X position.");
                Console.WriteLine(" - Must be a positive integer number smaller than the grid width.");
                string initialX = Console.ReadLine();   //bug: tratar parametros invalidos


                Console.WriteLine("Enter the intial robot Y position. ");
                Console.WriteLine(" - Must be a positive integer number smaller than the grid height.");
                string initialY = Console.ReadLine();   //bug: tratar parametros invalidos

                Console.WriteLine("Enter the intial robot facing direction. ");
                Console.WriteLine(" - N = North");
                Console.WriteLine(" - S = South");
                Console.WriteLine(" - L = East");
                Console.WriteLine(" - O = West.");
                string initialDirection = Console.ReadLine();   //bug: tratar parametros invalidos

                Robot robot = new Robot(int.Parse(initialX), int.Parse(initialY), initialDirection.ToUpperInvariant());
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
                            Console.WriteLine("Rotating left.");
                            robot.rotateLeft();
                            break;
                        case 'D':
                            Console.WriteLine("Rotating right.");
                            robot.rotateRight();
                            break;
                        case 'M':
                            Console.WriteLine("Moving ahead.");
                            robot.moveAhead();
                            break;
                        default:
                            Console.WriteLine("Invalid parameter. Ignoring...");    //tratar parametros invalidos?
                            break;
                    }
                }

                //Robot robot1 = new Robot(1, 2, "N");

                ////EM EM EM E MM
                //robot1.rotateLeft(); //e
                //robot1.moveAhead();  //m

                //robot1.rotateLeft(); //e
                //robot1.moveAhead();  //m

                //robot1.rotateLeft(); //e
                //robot1.moveAhead();  //m

                //robot1.rotateLeft(); //e

                //robot1.moveAhead();  //m
                //robot1.moveAhead();  //m

                Console.WriteLine("Robot final position:" + robot.AtributesToString());
                //Console.WriteLine("Do you want to initialize a robot? \n  Y - Yes\n  N - No");
                Console.ReadLine();
            }

            
        }
    }
}
