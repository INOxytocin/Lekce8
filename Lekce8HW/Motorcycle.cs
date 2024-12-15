using System;
using System.Drawing;

public class Motorcycle : Vehicle , IDriveable
{
    public string Type { get; }
	public Motorcycle(int id, int type) 
    {
        ID = id;
        switch (type) 
        {
            case 0:
                Type = "Land-Melee";
                break;
            case 1:
                Type = "Land-Ranged";
                break;
            case 2:
                Type = "Airbound-Ranged";
                break;
            case 3:
                Type = "Airbound-Bombarder";
                break;
            case 4:
                Type = "Spionage";
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
    public string DetailsWithColor()
    {
        Console.ForegroundColor = VehicleColor;
        if (EngineStatus)
        {
            return "Decepticol| " + "ID = " + ID + " READY TO DESTROY" + "|\n" + "| Mileage = " + Mileage + "| Purpose = " + Type + "|\n";
        }
        else if (!EngineStatus)
        {
            return "Decepticon| " + "ID = " + ID + " STAND BY" + "|\n" + "| Mileage = " + Mileage + "| Purpose = " + Type + "|\n";
        }
        else
        {
            return "Failed";
        }
        Console.ForegroundColor = ConsoleColor.White;

    }
    public override void PrintDetails()
    {
        Console.WriteLine(DetailsWithColor()); ;
        Console.ForegroundColor = ConsoleColor.White;

    }

}
