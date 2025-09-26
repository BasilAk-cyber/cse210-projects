using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Blind livingRoom = new Blind();
        livingRoom.Height = 18;
        livingRoom.Width = 12;
        livingRoom.Color = "Blue";
        Blind kitchen = new Blind();
        kitchen.Height = 20;
        kitchen.Width = 14;
        kitchen.Color = "Pink";

        House johnsonHouse = new House();

        johnsonHouse.AddBlind(kitchen);
        johnsonHouse.AddBlind(livingRoom);
        johnsonHouse.DisplayBlinds(); 
    }

    
}

