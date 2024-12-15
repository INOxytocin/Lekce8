using System.Drawing;

namespace Lekce8HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IDriveable[] driveables = new IDriveable[5];

            for (int i = 0; i < driveables.Length; i++)
            {
                driveables[i] = new Car(i, 1);
            }

            for (int i = 0; i < driveables.Length; i++)
            {
                if (i % 2 == 0)
                {
                    driveables[i].EngineOnOff();
                }
            }

            for (int i = 0; i < driveables.Length; i++)
            {
                Console.WriteLine(driveables[i]);
            }


            Console.ReadKey(); 
        }
    }
}
