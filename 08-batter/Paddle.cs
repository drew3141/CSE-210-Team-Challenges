using System;

namespace cse210_batter_csharp.Casting
{
    
    public class Paddle : Actor
    {
        
        public Paddle()
        {
            SetPosition(new Point((Constants.MAX_X-Constants.PADDLE_WIDTH)/2,Constants.MAX_Y-Constants.PADDLE_HEIGHT));
            SetVelocity(new Point(0,0));
            SetWidth(Constants.PADDLE_WIDTH);
            SetHeight(Constants.PADDLE_HEIGHT);
            SetImage(Constants.IMAGE_PADDLE);
        }
    }
}