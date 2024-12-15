using System;
using System.Drawing;

public class Car : Vehicle , IDriveable
{
    public string Type { get; }
	public Car(int id, int type)
	{
        ID = id;
        switch (type) 
        {
            case 0:
                Type = "Protector";
                break;
            case 1:
                Type = "Scout";
                break;
            case 2:
                Type = "Artillery";
                break;
            case 3:
                Type = "Undercover";
                break;
            case 4:
                Type = "Peacekeeper";
                break;
            default:
                throw new ArgumentException("Invalid car type");

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
    public string DetailsWithColor() //Vše je vypasné v barvě auta
    {
        Console.ForegroundColor = VehicleColor;
        if (EngineStatus) 
        {
             return "Autobot| " + "ID = " + ID + " READY TO PROTECT" +     "|\n"+  "| Mileage = " + Mileage + "| Purpose = " + Type + "|\n";
        }
        else if (!EngineStatus)
        {
            return "Autobot| " + "ID = " + ID + " STAND BY" + "|\n" + "| Mileage = " + Mileage + "| Purpose = " + Type + "|\n";
        }
        else
        {
            return "Failed";
        }
        Console.ForegroundColor = ConsoleColor.White;


    }
    public override void PrintDetails()// Nevymyslel jsem jiný způsob, jak znovu vrátit zpět bílou barvu
    {
        Console.WriteLine(DetailsWithColor()); ;
        Console.ForegroundColor = ConsoleColor.White;

    }


}
