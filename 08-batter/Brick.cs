using System;

namespace cse210_batter_csharp.Casting
{
    
    public class Brick : Actor
    {
        protected int _strength;
        protected int _tier;

        public Brick(int x, int y, int z)
        {
            _strength=(z-7)*-1;
            _tier = z;
            SetPosition(new Point(x,y));
            SetVelocity(new Point(0,0));
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
            SetImage($"./Assets/brick-{_tier}.png");
        }

        public void ReduceTier()
        {
            _strength--;
            _tier--;
            SetImage($"./Assets/brick-{_tier}.png");
        }

        public bool IsAlive()
        {
            if (_strength >0)
            {
                return true;
            }
            return false;
        }

    }
}