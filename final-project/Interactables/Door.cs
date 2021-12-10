using System;
using Final_Project.Casting;

namespace Final_Project.Interactables
{
    public class Door : Actor
    {
        public bool isUnlocked = true;

        public Door(int xPosition, int yPosition, bool unlocked)
        {
            if (unlocked) 
            {
                SetImage("./Assets/Door.png");
            }
            else {
                SetImage("./Assets/DoorLocked.png");
                isUnlocked = false;
            }
            SetPosition(new Point(xPosition, yPosition));
            SetWidth(Constants.DOOR_WIDTH);
            SetHeight(Constants.DOOR_HEIGHT);
        }

        public void unlockDoor()
        {
            SetImage("./Assets/Door.png");
            isUnlocked = true;
        }

        public void lockDoor()
        {
            SetImage("./Assets/DoorLocked.png");
            isUnlocked = false;
        }
    }
}