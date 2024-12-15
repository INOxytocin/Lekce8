using System;
using System.Drawing;

public class Car : Vehicle , IDriveable
{
	public Car(int id)
	{
        EngineStatus = false;
        Mileage = 0;
        ID = id;
    }
    public Car(int id, Color color)
    {
        EngineStatus = false;
        Mileage = 0;
        ID = id;
        VehicleColor = color;
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
        return "ID = " + ID + "| Engine = " + EngineStatus + "| Mileage = " + Mileage + "| VehicleColor = " + VehicleColor + "|\n"; 
    }
}
