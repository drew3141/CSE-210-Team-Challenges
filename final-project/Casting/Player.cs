using System;
using Final_Project.Casting;

namespace Final_Project.Casting
{
    public class Player : Actor
    {
        public bool CanJump = true;
        
        public Player()
        {
            SetImage("./Assets/Stone40x40.png");
            SetPosition(new Point(Constants.MAX_X/2,Constants.MAX_Y-Constants.TERRAIN_HEIGHT-Constants.PLAYER_HEIGHT-40));
            SetWidth(Constants.PLAYER_WIDTH);
            SetHeight(Constants.PLAYER_HEIGHT);
        }

        public void Jump()
        {
            SetVelocity(new Point(GetVelocity().GetX(),-20));
            CanJump = false;
        }
    }
}