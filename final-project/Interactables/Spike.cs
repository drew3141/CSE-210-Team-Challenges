using System;
using Final_Project.Casting;

namespace Final_Project.Interactables
{
    public class Spike : Actor
    {
        public Spike(int xPosition, int yPosition, string direction)
        {
            SetPosition(new Point(xPosition, yPosition));
            switch(direction)
            {
                case "left":
                    SetWidth(Constants.SPIKE_HEIGHT);
                    SetHeight(Constants.SPIKE_WIDTH);
                    SetImage("./Assets/SpikesLeft.png");
                    break;
                case "right":
                    SetWidth(Constants.SPIKE_HEIGHT);
                    SetHeight(Constants.SPIKE_WIDTH);
                    SetImage("./Assets/SpikesRight.png");
                    break;
                case "top":
                    SetWidth(Constants.SPIKE_WIDTH);
                    SetHeight(Constants.SPIKE_HEIGHT);
                    SetImage("./Assets/SpikesTop.png");
                    break;
                case "bottom":
                    SetWidth(Constants.SPIKE_WIDTH);
                    SetHeight(Constants.SPIKE_HEIGHT);
                    SetImage("./Assets/SpikesBottom.png");
                    break;
            }
        }
    }
}