using System;
using Final_Project.Casting;

namespace Final_Project.Interactables
{
    public class Lever : Actor
    {
        public bool powerOn = false;
        public int delay = 0;
        
        public Lever(int xPosition, int yPosition)
        {
            SetPosition(new Point(xPosition, yPosition));
            SetWidth(Constants.LEVER_WIDTH);
            SetHeight(Constants.LEVER_HEIGHT);
            SetImage("./Assets/LeverOff.png");
        }

        public void flipState()
        {
            if (powerOn)
            {
                powerOn = false;
                SetImage("./Assets/LeverOff.png");
            }
            else
            {
                powerOn = true;
                SetImage("./Assets/LeverOn.png");
            }
        }
    }
}