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
        switch (type) 
        {
            case 0:
                Type = "Optimus Prime";
                break;
            case 1:
                Type = "Prime Nova";
                break;
            case 2:
                Type = "Rodimus Prime";
                break;
            case 3:
                Type = "Alpha Prime";
                break;
            case 4:
                Type = "Zeta Prime";
                break;

        }
    }
    
    public override void Repaint(ConsoleColor color) 
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
            EngineStatus = !EngineStatus;
        }
        else
        {
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

    public string DetailsWithColor()
    {
        Console.ForegroundColor = VehicleColor;
        if (EngineStatus)
        {
            return "Prime| " + "ID = " + ID + " READY TO LEAD" + "|\n" + "| Mileage = " + Mileage + "| Name = " + Type + "Civilians on board? " + Load + "|\n";
        }
        else if (!EngineStatus)
        {
            return "Prime| " + "ID = " + ID + " STAND BY" + "|\n" + "| Mileage = " + Mileage + "| Name = " + Type + "Civilians on board? " + Load + "|\n";
        }
        else 
        {
            return "Failed";
        }

    }
    public override void PrintDetails()
    {
        Console.WriteLine(DetailsWithColor()); ;
        Console.ForegroundColor = ConsoleColor.White;

    }


}

