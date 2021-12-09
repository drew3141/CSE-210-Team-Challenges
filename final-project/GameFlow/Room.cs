using System;
using System.Collections.Generic;
using Final_Project.Casting;
using Final_Project.Interactables;

namespace Final_Project.GameFlow
{
    public class Room
    {
        public Dictionary<string, List<Actor>> rooms = new Dictionary<string, List<Actor>>();

        public Room()
        {
            //Create list of actors for room 1
            rooms["room1"] = new List<Actor>();
            Door door1 = new Door(720, Constants.MAX_Y-400, true);
            rooms["room1"].Add(door1);
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain leftWall = new Terrain(0,i*Constants.TERRAIN_HEIGHT);
                rooms["room1"].Add(leftWall);
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain rightWall = new Terrain(Constants.MAX_X-Constants.TERRAIN_WIDTH,i*Constants.TERRAIN_HEIGHT);
                rooms["room1"].Add(rightWall);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain floor = new Terrain(i*Constants.TERRAIN_WIDTH,Constants.MAX_Y-Constants.TERRAIN_HEIGHT);
                rooms["room1"].Add(floor);
            }
            for (int i = 0; i < 10;i++)
            {
                Terrain platform1 = new Terrain(Constants.TERRAIN_WIDTH+(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-160);
                rooms["room1"].Add(platform1);
            }
            for (int i = 0; i < 10;i++)
            {
                Terrain platform1 = new Terrain(400+(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-320);
                rooms["room1"].Add(platform1);
            }
            //Create list of actors for room 2
            rooms["room2"] = new List<Actor>();
            Door door2 = new Door(Constants.MAX_X-520, Constants.MAX_Y-600, false);
            rooms["room2"].Add(door2);
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain leftWall = new Terrain(0,i*Constants.TERRAIN_HEIGHT);
                rooms["room2"].Add(leftWall);
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain rightWall = new Terrain(Constants.MAX_X-Constants.TERRAIN_WIDTH,i*Constants.TERRAIN_HEIGHT);
                rooms["room2"].Add(rightWall);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain floor = new Terrain(i*Constants.TERRAIN_WIDTH,Constants.MAX_Y-Constants.TERRAIN_HEIGHT);
                rooms["room2"].Add(floor);
            }
            for (int i = 1; i < 5;i++)
            {
                Terrain platform1 = new Terrain(Constants.MAX_X-(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-200);
                rooms["room2"].Add(platform1);
            }
            for (int i = 1; i < 5;i++)
            {
                Terrain platform2 = new Terrain((Constants.MAX_X-200)-(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-360);
                rooms["room2"].Add(platform2);
            }
            for (int i = 1; i < 5;i++)
            {
                Terrain platform3 = new Terrain((Constants.MAX_X-400)-(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-520);
                rooms["room2"].Add(platform3);
            }
            for (int i = 1; i < 5;i++)
            {
                Terrain platform4 = new Terrain(Constants.MAX_X-(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-520);
                rooms["room2"].Add(platform4);
            }
        }
    }


}