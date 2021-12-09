using System;
using Final_Project.Casting;

namespace Final_Project.Casting
{
    public class Player : Actor
    {
        public bool CanJump = true;
        public int GravityModifier = 1;
        
        public Player()
        {
            SetPosition(new Point(Constants.MAX_X/2,Constants.MAX_Y-Constants.TERRAIN_HEIGHT-Constants.PLAYER_HEIGHT-200));
            SetWidth(Constants.PLAYER_WIDTH);
            SetHeight(Constants.PLAYER_HEIGHT);
        }

        public void Jump()
        {
            SetVelocity(new Point(GetVelocity().GetX(),-18));
            CanJump = false;
        }

        public void OpenDoor()
        {
            //Have this change the current room to the next room, or tell room to do that or something
        }
    }
}