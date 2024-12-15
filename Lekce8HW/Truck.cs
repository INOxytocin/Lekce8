using System;
using System.Drawing;

public class Truck : Vehicle , IDriveable
{
    public required string Type { get; set; }
    public bool Load { get; set; }
    public int LoadWeight {  get; set; }
	public Truck(int id, int type)
	{
        ID = id;
        Load = false;
        LoadWeight = 0;
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

    private
    public override string ToString()
    {
        return "ID = " + ID + "| Engine = " + EngineStatus + "| Mileage = " + Mileage + "| VehicleColor = " + VehicleColor + "| Type = " + Type + "|\n"; 
    }

    
}

