using System;
using System.Drawing;

public abstract class Vehicle
{
	protected float Mileage { get; set; }
	protected int ID { get; set; }

	protected bool EngineStatus { get; set; }
	protected KnownColor VehicleColor { get; set; }
	protected KnownColor[] _collorPallete = { KnownColor.Orange, KnownColor.Blue, KnownColor.Brown, KnownColor.Yellow, KnownColor.Red };
	public KnownColor ColorPallete(int i)
	{
		return _collorPallete[i];
	}



    public Vehicle()
	{
        EngineStatus = false;
        Mileage = 0;
		VehicleColor = KnownColor.Black;
    }

	public abstract void Repaint(KnownColor color);
	public virtual void EngineOnOff()	//Asi určitě by bylo lepší udělat 2 rozdílné funkce a už vůbec ne dávat zhasnutí motoru do ELSE místo ELSE IF.
    {									//Navíc jsem si chtěl vyzkoušet pracovat s obrácením bool hodnot pomocí !. A obecně řešit problémy, které s tímto přístupem nastanou.
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
	






}
