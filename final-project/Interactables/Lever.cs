using System;
using Final_Project.Casting;

namespace Final_Project.Interactables
{
    public class Lever : Actor
    {
        public bool powerOn = false;
        public string orientation = "";
        public int delay = 0;
        
        public Lever(int xPosition, int yPosition, bool isTop)
        {
            SetPosition(new Point(xPosition, yPosition));
            SetWidth(Constants.LEVER_WIDTH);
            SetHeight(Constants.LEVER_HEIGHT);
            if (isTop) {
                SetImage("./Assets/LeverOffTop.png");
                orientation = "top";
            }
            else {
                SetImage("./Assets/LeverOff.png");
                orientation = "bottom";
            }
        }

        public void flipState()
        {
            if (powerOn)
            {
                powerOn = false;
                if (orientation == "bottom")
                {
                    SetImage("./Assets/LeverOff.png");
                }
                else {
                    SetImage("./Assets/LeverOffTop.png");
                }
            }
            else
            {
                powerOn = true;
                if (orientation == "bottom")
                {
                    SetImage("./Assets/LeverOn.png");
                }
                else {
                    SetImage("./Assets/LeverOnTop.png");
                }
            }
        }
    }
}