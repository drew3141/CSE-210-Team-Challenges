using System;
using Final_Project.Casting;

namespace Final_Project.Casting
{
    public class Player : Actor
    {
        public bool CanJump = true;
        public int GravityModifier = 1;
        public bool isAlive = true;
        public bool waitingToRelease = false;
        
        public Player()
        {
            SetImage("./Assets/PlayerRight1.png");
            SetPosition(new Point(Constants.MAX_X/2,Constants.MAX_Y-Constants.TERRAIN_HEIGHT-Constants.PLAYER_HEIGHT-200));
            SetWidth(Constants.PLAYER_WIDTH);
            SetHeight(Constants.PLAYER_HEIGHT);
        }

        public void Jump()
        {
            if (CanJump && !waitingToRelease) 
            {
                SetVelocity(new Point(GetVelocity().GetX(),-18*GravityModifier));
                CanJump = false;
            }
        }

        public void Move(Point Direction)
        {
            if (Direction.GetX() == 0)
            {
                SetVelocity(new Point(0, GetVelocity().GetY()));
            }
            else
            {
                SetVelocity(new Point(GetVelocity().GetX()+Direction.GetX(), GetVelocity().GetY()));
                if (GetVelocity().GetX() > 7)
                {
                    SetVelocity(new Point(7, GetVelocity().GetY()));
                }
                else if (GetVelocity().GetX() < -7)
                {
                    SetVelocity(new Point(-7, GetVelocity().GetY()));
                }
            }
        }

        public void Reset()
        {
            SetPosition(new Point(Constants.MAX_X/2, Constants.MAX_Y-200));
            GravityModifier = 1;
            SetImage("./Assets/PlayerRight1.png");
        }
    }
}