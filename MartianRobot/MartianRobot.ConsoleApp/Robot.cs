using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianRobot.ConsoleApp
{
    class Robot
    {
        public int xPosition;
        public int yPosition;
        public string facingDirection;

        public Robot(int xPosition, int yPosition, string facingDirection)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.facingDirection = facingDirection;
        }

        public void moveAhead()
        {
            switch (facingDirection.ToUpper())
            {
                case "N":
                    yPosition++;
                    break;

                case "S":
                    yPosition--;
                    break;

                case "L":
                    xPosition--;
                    break;

                case "O":
                    xPosition++;
                    break;

            }
        }

        public void rotateLeft()
        {
            switch (facingDirection.ToUpper())
            {
                case "N":
                    facingDirection = "L";
                    break;

                case "S":
                    facingDirection = "O";
                    break;

                case "L":
                    facingDirection = "S";
                    break;

                case "O":
                    facingDirection = "N";
                    break;
                
            }
        }

        public void rotateRight()
        {
            switch (facingDirection.ToUpper())
            {
                case "N":
                    facingDirection = "O";
                    break;

                case "S":
                    facingDirection = "L";
                    break;

                case "L":
                    facingDirection = "N";
                    break;

                case "O":
                    facingDirection = "S";
                    break;

            }
        }

        public string AtributesToString()
        {
            return $"{xPosition},{yPosition},{facingDirection}";
        }
    }
}
