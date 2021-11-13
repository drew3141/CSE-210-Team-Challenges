using System;

namespace cse210_batter_csharp.Casting
{
    
    public class Brick : Actor
    {
        protected int _tier = 0;
        protected int _lives = 0;

        public Brick(int x, int y, int z)
        {
            switch (z)
            {
                case 7:
                    _lives = 1;
                    _tier = 1;
                    break;
                case 6:
                    _lives = 2;
                    _tier = 2;
                    break;
                case 5:
                    _lives = 3;
                    _tier = 3;
                    break;
                case 4:
                    _lives = 4;
                    _tier = 4;
                    break;
                case 3:
                    _lives = 5;
                    _tier = 5;
                    break;
                case 2:
                    _lives = 6;
                    _tier = 6;
                    break;
                case 1:
                    _lives = 7;
                    _tier = 7;
                    break;
            }
            SetPosition(new Point(x,y));
            SetVelocity(new Point(0,0));
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
            SetImage($"./Assets/brick-{_tier}.png");
        }

        public void ReduceTier()
        {
            _tier--;
            _lives--;
            SetImage($"./Assets/brick-{_tier}.png");
        }

        public bool IsAlive()
        {
            if (_lives > 0)
            {
                return true;
            }
            return false;
        }

    }
}