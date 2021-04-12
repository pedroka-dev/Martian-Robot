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

            Robot robot1 = new Robot(1, 2, "N");

            //EM EM EM E MM
            robot1.rotateLeft(); //e
            robot1.moveAhead();  //m

            robot1.rotateLeft(); //e
            robot1.moveAhead();  //m

            robot1.rotateLeft(); //e
            robot1.moveAhead();  //m

            robot1.rotateLeft(); //e

            robot1.moveAhead();  //m
            robot1.moveAhead();  //m

            Console.WriteLine(robot1.AtributesToString());

            Console.ReadLine();

            
        }
    }
}
