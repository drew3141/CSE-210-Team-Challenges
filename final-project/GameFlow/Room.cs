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
            Random r = new Random();
            //Create list of actors for room 1
            for (int i = 1; i <=8; i++)
            {
                rooms[$"room{i}"] = new List<Actor>();
                rooms[$"doors{i}"] = new List<Actor>();
                rooms[$"levers{i}"] = new List<Actor>();
                rooms[$"spikes{i}"] = new List<Actor>();
            }
            Door door1 = new Door(720, Constants.MAX_Y-400, true);
            rooms["doors1"].Add(door1);
            Lever lever1 = new Lever(Constants.MAX_X,0, false);
            rooms["levers1"].Add(lever1);
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
                Terrain ceiling = new Terrain(i*Constants.TERRAIN_WIDTH,0);
                rooms["room1"].Add(ceiling);
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
            Door door2 = new Door(Constants.MAX_X-600, Constants.MAX_Y-600, false);
            rooms["doors2"].Add(door2);
            Lever lever2 = new Lever(Constants.MAX_X-100,Constants.MAX_Y-520-Constants.LEVER_HEIGHT, false);
            rooms["levers2"].Add(lever2);
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
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain ceiling = new Terrain(i*Constants.TERRAIN_WIDTH,0);
                rooms["room2"].Add(ceiling);
            }
            for (int i = 1; i < 5;i++)
            {
                Terrain platform1 = new Terrain(Constants.MAX_X-(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-200);
                rooms["room2"].Add(platform1);
            }
            for (int i = 1; i < 5;i++)
            {
                Terrain platform2 = new Terrain((Constants.MAX_X-240)-(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-360);
                rooms["room2"].Add(platform2);
            }
            for (int i = 1; i < 5;i++)
            {
                Terrain platform3 = new Terrain((Constants.MAX_X-480)-(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-520);
                rooms["room2"].Add(platform3);
            }
            for (int i = 1; i < 5;i++)
            {
                Terrain platform4 = new Terrain(Constants.MAX_X-(i*Constants.TERRAIN_WIDTH),Constants.MAX_Y-520);
                rooms["room2"].Add(platform4);
            }
            //Create list of actors for room 3
            Door door3 = new Door(160, 140-Constants.DOOR_HEIGHT, false);
            rooms["doors3"].Add(door3);
            Lever lever3 = new Lever(1130,Constants.MAX_Y-520-Constants.LEVER_HEIGHT, false);
            rooms["levers3"].Add(lever3);
            for (int i = 1; i < 10; i+= 2)
            {
                Spike spikes = new Spike(160*i + 40, Constants.MAX_Y-40-Constants.SPIKE_HEIGHT, "bottom");
                rooms["spikes3"].Add(spikes);
            }
            for (int i =1; i< 10; i++)
            {
                Terrain platform1 = new Terrain(160*i, 20+120*i);
                rooms["room3"].Add(platform1);
                if (i > 5 && i < 8)
                {
                    Terrain platform2 = new Terrain(160*i, Constants.MAX_Y-40-(120*(i-3)));
                    rooms["room3"].Add(platform2);
                }
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain leftWall = new Terrain(0,i*Constants.TERRAIN_HEIGHT);
                rooms["room3"].Add(leftWall);
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain rightWall = new Terrain(Constants.MAX_X-Constants.TERRAIN_WIDTH,i*Constants.TERRAIN_HEIGHT);
                rooms["room3"].Add(rightWall);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain floor = new Terrain(i*Constants.TERRAIN_WIDTH,Constants.MAX_Y-Constants.TERRAIN_HEIGHT);
                rooms["room3"].Add(floor);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain ceiling = new Terrain(i*Constants.TERRAIN_WIDTH,0);
                rooms["room3"].Add(ceiling);
            }
            //Create list of actors for room 4
            Door door4 = new Door(880, 200, true);
            rooms["doors4"].Add(door4);
            Lever lever4 = new Lever(200,Constants.MAX_Y-200-Constants.LEVER_HEIGHT, false);
            rooms["levers4"].Add(lever4);
            Spike spikes4_1 = new Spike(160, 200, "top");  
            Spike spikes4_2 = new Spike(320, 200, "top");
            Spike spikes4_3 = new Spike(780, 200, "top");
            rooms["spikes4"].Add(spikes4_1); 
            rooms["spikes4"].Add(spikes4_2);  
            rooms["spikes4"].Add(spikes4_3);          
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain leftWall = new Terrain(0,i*Constants.TERRAIN_HEIGHT);
                rooms["room4"].Add(leftWall);
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain rightWall = new Terrain(Constants.MAX_X-Constants.TERRAIN_WIDTH,i*Constants.TERRAIN_HEIGHT);
                rooms["room4"].Add(rightWall);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain floor = new Terrain(i*Constants.TERRAIN_WIDTH,Constants.MAX_Y-Constants.TERRAIN_HEIGHT);
                rooms["room4"].Add(floor);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain ceiling = new Terrain(i*Constants.TERRAIN_WIDTH,0);
                rooms["room4"].Add(ceiling);
            }
            for (int i = 0; i < 7; i++)
            {
                Terrain platform1 = new Terrain((i*Constants.TERRAIN_WIDTH)+120, Constants.MAX_Y-200);
                rooms["room4"].Add(platform1);
            }
            for (int i = 10; i < 13; i++)
            {
                Terrain platform2 = new Terrain((i*Constants.TERRAIN_WIDTH)+120, Constants.MAX_Y-360);
                rooms["room4"].Add(platform2);

            }
            for (int i = 15; i < 21; i++)
            {
                Terrain platform3 = new Terrain(i*Constants.TERRAIN_WIDTH+120, 160);
                rooms["room4"].Add(platform3);
            }
            for (int i = 0; i < 7; i++)
            {
                Terrain platform4 = new Terrain((i*Constants.TERRAIN_WIDTH)+120, 160);
                rooms["room4"].Add(platform4);
            }
            //Create list of actors for room 5
            Door door5 = new Door(200, Constants.MAX_Y-560, true);
            rooms["doors5"].Add(door5);
            Lever lever5_1 = new Lever(200,Constants.TERRAIN_HEIGHT, true);
            Lever lever5_2 = new Lever(Constants.MAX_X-240,Constants.MAX_Y-Constants.LEVER_HEIGHT-Constants.TERRAIN_HEIGHT, false);
            rooms["levers5"].Add(lever5_1);
            rooms["levers5"].Add(lever5_2);
            for (int i = 10; i < 14; i++)
            {
                Terrain platform2 = new Terrain((i*Constants.TERRAIN_WIDTH)+120, Constants.MAX_Y-240);
                rooms["room5"].Add(platform2);

            }
            for (int i = 4; i < 8; i++)
            {
                Terrain platform3 = new Terrain((i*Constants.TERRAIN_WIDTH), Constants.MAX_Y-480);
                rooms["room5"].Add(platform3);

            }
            for (int i = 17; i < 21; i++)
            {
                Terrain platform2 = new Terrain((i*Constants.TERRAIN_WIDTH)+120, Constants.MAX_Y-400);
                rooms["room5"].Add(platform2);

            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain leftWall = new Terrain(0,i*Constants.TERRAIN_HEIGHT);
                rooms["room5"].Add(leftWall);
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain rightWall = new Terrain(Constants.MAX_X-Constants.TERRAIN_WIDTH,i*Constants.TERRAIN_HEIGHT);
                rooms["room5"].Add(rightWall);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain floor = new Terrain(i*Constants.TERRAIN_WIDTH,Constants.MAX_Y-Constants.TERRAIN_HEIGHT);
                rooms["room5"].Add(floor);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain ceiling = new Terrain(i*Constants.TERRAIN_WIDTH,0);
                rooms["room5"].Add(ceiling);
            }

            //Create list of actors for room 6
            Door door6 = new Door(r.Next(120, 80+ Constants.MAX_X/2), r.Next(120, Constants.MAX_Y/2 - 120), true);
            rooms["doors6"].Add(door6);
            Lever lever6 = new Lever(120,Constants.MAX_Y-Constants.TERRAIN_HEIGHT-Constants.LEVER_HEIGHT, false);
            rooms["levers6"].Add(lever6);
            for (int i = 0; i < 6; i++)
            {
                int randX = r.Next(80, 40+Constants.MAX_X/2);
                int randY = r.Next(80, 40+Constants.MAX_Y/2);
                Terrain randomTerrain = new Terrain(randX, randY);
                rooms["room6"].Add(randomTerrain);
            }
            for (int i = 0; i < 6; i++)
            {
                int randX = r.Next(Constants.MAX_X/2 - 40, Constants.MAX_X-120);
                int randY = r.Next(Constants.MAX_Y/2 - 40, Constants.MAX_Y-120);
                Terrain randomTerrain = new Terrain(randX, randY);
                rooms["room6"].Add(randomTerrain);
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain leftWall = new Terrain(0,i*Constants.TERRAIN_HEIGHT);
                rooms["room6"].Add(leftWall);
            }
            for (int i = 0; i < Constants.MAX_Y/Constants.TERRAIN_HEIGHT;i++)
            {
                Terrain rightWall = new Terrain(Constants.MAX_X-Constants.TERRAIN_WIDTH,i*Constants.TERRAIN_HEIGHT);
                rooms["room6"].Add(rightWall);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain floor = new Terrain(i*Constants.TERRAIN_WIDTH,Constants.MAX_Y-Constants.TERRAIN_HEIGHT);
                rooms["room6"].Add(floor);
            }
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain ceiling = new Terrain(i*Constants.TERRAIN_WIDTH,0);
                rooms["room6"].Add(ceiling);
            }

            //Create list of actors for win screen
            Door door7 = new Door(Constants.MAX_X, Constants.MAX_Y, true);
            rooms["doors7"].Add(door7);
            Lever lever7 = new Lever(Constants.MAX_X/2,Constants.MAX_Y-Constants.TERRAIN_HEIGHT-Constants.LEVER_HEIGHT, false);
            rooms["levers7"].Add(lever7);
            for (int i = 0; i < Constants.MAX_X/Constants.TERRAIN_WIDTH;i++)
            {
                Terrain floor = new Terrain(i*Constants.TERRAIN_WIDTH,Constants.MAX_Y-Constants.TERRAIN_HEIGHT);
                rooms["room7"].Add(floor);
            }
        }
    }


}