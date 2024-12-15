using System.Drawing;

namespace Lekce8HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            //------------------------ÚKOL 4 A 6----------------------------
            //IDriveable[] driveable = new IDriveable[150];
            //Car[] cars = new Car[50];
            //Motorcycle[] motorcycles = new Motorcycle[50];
            //Truck[] trucks = new Truck[50];

            //for (int i = 0; i < driveable.Length; i++)
            //{
            //    if (i < 50)
            //    {
            //        cars[i] = new Car(i, rand.Next(0, 4));
            //        driveable[i] = cars[i];
            //    }
            //    else if (i >= 50 && i < 100)
            //    {
            //        motorcycles[i-50] = new Motorcycle(i, rand.Next(0, 4));
            //        driveable[i] = motorcycles[i-50];
            //    }
            //    else if (i >= 100 && i < 150)
            //    {
            //        trucks[i-100] = new Truck(i, rand.Next(0, 4));
            //        driveable[i] = trucks[i-100];
            //    }

            //}
            //for (int i = 0; i < driveable.Length; i++)
            //{
            //    driveable[i].Drive(1000);
            //}
            //for (int i = 0;i < driveable.Length; i++)
            //{
            //    Console.WriteLine(driveable[i]);

            //}
            //--------------------------------------------------------------

            //------------------------ÚKOL 5 A 7----------------------------
           
            Car[] cars2 = new Car[30];
            Motorcycle[] motorcycles2 = new Motorcycle[20];
            Truck[] trucks2 = new Truck[10];
            Vehicle[] transformers = new Vehicle[60];
            for (int i = 0; i < transformers.Length; i++)
            {
                if (i < 30)
                {
                    cars2[i] = new Car(i, rand.Next(0, 4));
                    transformers[i] = cars2[i];
                }
                else if (i >= 30 && i < 50)
                {
                    motorcycles2[i - 30] = new Motorcycle(i, rand.Next(0, 4));
                    transformers[i] = motorcycles2[i - 30];
                }
                else if (i >= 50 && i < 60)
                {
                    trucks2[i - 50] = new Truck(i, rand.Next(0, 4));
                    transformers[i] = trucks2[i - 50];
                }
                
            }
            for (int i = 0; i < transformers.Length; i++)
            {

                transformers[i].Repaint(transformers[i].ColorPallete(rand.Next(0, 4)));

            }
            for (int i = 0; i < transformers.Length; i++)
            {
                Console.WriteLine(transformers[i]);

            }
            Console.ReadKey();
        }
    }
}
