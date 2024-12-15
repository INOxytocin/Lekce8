﻿using System;
using System.Drawing;

public class Motorcycle : Vehicle , IDriveable
{
    public string Type { get; }
	public Motorcycle(int id, int type) 
    {
        ID = id;
        switch (type) //racing, harley, minibike, cross, quadbike
        {
            case 0:
                Type = "racing";
                break;
            case 1:
                Type = "harley";
                break;
            case 2:
                Type = "minibike";
                break;
            case 3:
                Type = "cross";
                break;
            case 4:
                Type = "quadbike";
                break;

        }
    }
    
    public override void Repaint(KnownColor color) 
    {
        VehicleColor = color;
    }
    public void Drive(int distance)
    {
        Mileage += distance;
    }
    public override void EngineOnOff() 
    {                         
        if (EngineStatus == false)
        {
            Console.WriteLine("Engine is STARTING...");
            Console.WriteLine("DECEPTICON "+ ID +" ARMED");
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
        return "Motorcycle " + "ID = " + ID + "| Engine = " + EngineStatus + "| Mileage = " + Mileage + "| Type = " + Type + "| Color = " + VehicleColor + "|\n"; 
    }
    //závodní, harley, minibike, cross, quadbike
    //racing, harley, minibike, cross, quadbike
}
