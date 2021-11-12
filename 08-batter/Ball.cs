using System;

namespace cse210_batter_csharp.Casting
{
    
    public class Ball : Actor
    {
        
        public Ball()
        {
            SetPosition(new Point(Constants.BALL_X-10,Constants.BALL_Y));
            SetVelocity(new Point(Constants.BALL_DX,Constants.BALL_DY));
            SetWidth(Constants.BALL_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetImage(Constants.IMAGE_BALL);
        }
    }
}