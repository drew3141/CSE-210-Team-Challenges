using System;
using Final_Project.Casting;

namespace Final_Project.Interactables
{
    public class Terrain : Actor
    {
        public Terrain(int xPosition, int yPosition, int width, int height)
        {
            SetImage("./Assets/Stone40x40.png");
            SetPosition(new Point(xPosition,yPosition));
            SetHeight(height);
            SetWidth(width);
        }
    }
}