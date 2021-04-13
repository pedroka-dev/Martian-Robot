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

        public void moveAhead(int width, int height)
        {
            switch (facingDirection.ToUpper())
            {
                case "N":
                    if(yPosition < height)
                        yPosition++;
                    break;

                case "S":
                    if(yPosition > 0)
                        yPosition--;
                    break;

                case "L":
                    if (xPosition < width)
                        xPosition++;
                    break;

                case "O":
                    if (xPosition > 0)
                       xPosition--;
                    break;

            }
        }

        public void rotateLeft()
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

        public void rotateRight()
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

        public string AtributesToString()
        {
            return $"{xPosition},{yPosition},{facingDirection}";
        }
    }
}
