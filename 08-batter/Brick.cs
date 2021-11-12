using System;

namespace cse210_batter_csharp.Casting
{
    
    public class Brick : Actor
    {
        protected int _strength;

        public Brick(int x, int y, int brickTier)
        {
            SetPosition(new Point(x,y));
            SetVelocity(new Point(0,0));
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
            SetImage($"./Assets/brick-{brickTier}.png");
            _strength=(brickTier-7)*-1;
        }



    }
}