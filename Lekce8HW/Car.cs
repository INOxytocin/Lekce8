using System;
using System.Drawing;

public class Car : Vehicle , IDriveable
{
    public string Type { get; }
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
            default:
                throw new ArgumentException("Invalid car type");

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
            Console.WriteLine("Autobot" + ID + "ready to protect");
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
        return "Car " + "ID = " + ID + "| Engine = " + EngineStatus + "| Mileage = " + Mileage + "| Purpose = " + Type + "| Color = " + VehicleColor + "|\n"; 
    }
    // rodinné, terénní, závodní, víceúčelové, speciální
    
}
