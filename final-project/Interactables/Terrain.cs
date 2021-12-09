using System;
using Final_Project.Casting;

namespace Final_Project.Interactables
{
    public class Terrain : Actor
    {
        public Terrain(int xPosition, int yPosition)
        {
            SetImage("./Assets/Stone40x40.png");
            SetPosition(new Point(xPosition,yPosition));
            SetHeight(Constants.TERRAIN_HEIGHT);
            SetWidth(Constants.TERRAIN_WIDTH);
        }
    }
}