﻿using System;
using System.Drawing;

public class Car : Vehicle , IDriveable
{
    public required string Type { get; set; }
	public Car(int id, int type)
	{
        ID = id;
        switch (type) // family, off-road, racing, multipurpose, special
        {
            case 0:
                Type = "family";
                break;
            case 1:
                Type = "off-road";
                break;
            case 2:
                Type = "racing";
                break;
            case 3:
                Type = "multipurpose";
                break;
            case 4:
                Type = "special";
                break;

        }

    }
    
    public override void Repaint(Color color) 
    {

    }
    public void Drive(int distance)
    {
        Mileage += distance;
    }
    public void EngineOnOff() 
    {                         
        if (EngineStatus == false)
        {
            Console.WriteLine("Engine is STARTING...");
            EngineStatus = !EngineStatus;
        }
        else
        {
            Console.WriteLine("Engine SHUT DOWN");
            EngineStatus = !EngineStatus;
        }

    }
    public override string ToString()
    {
        return "ID = " + ID + "| Engine = " + EngineStatus + "| Mileage = " + Mileage + "| VehicleColor = " + VehicleColor + "| Purpose = " + Type + "|\n"; 
    }
    // rodinné, terénní, závodní, víceúčelové, speciální
    
}
