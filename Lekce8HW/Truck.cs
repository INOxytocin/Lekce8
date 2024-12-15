using System;
using System.Drawing;

public class Truck : Vehicle , IDriveable
{
    public string Type { get; }
    public bool Load { get; set; }
	public Truck(int id, int type)
	{
        ID = id;
        Load = false;
        switch (type) // garbage, construction, heavy-load, ice, sand
        {
            case 0:
                Type = "garbage";
                break;
            case 1:
                Type = "construction";
                break;
            case 2:
                Type = "heavy-load";
                break;
            case 3:
                Type = "ice";
                break;
            case 4:
                Type = "sand";
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
            Console.WriteLine("Diesel Injected...");
            Console.WriteLine("Engine is STARTING...");
            Console.WriteLine("Optimus Prime ready to roll...");
            EngineStatus = !EngineStatus;
        }
        else
        {
            Console.WriteLine("Engine SHUT DOWN");
            EngineStatus = !EngineStatus;
        }

    }
    public void LoadUp()
    {
        Load = true;
    }
    public void LoadOff()
    {
        Load = false;
    }

    public override string ToString()
    {
        return "Truck " + "ID = " + ID + "| Engine = " + EngineStatus + "| Mileage = " + Mileage + "| Type = " + Type + "| Loaded? = " + Load + "| Color = " + VehicleColor + "\n"; 
    }

    
}

