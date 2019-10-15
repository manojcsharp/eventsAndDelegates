using System;
using ClassLibrary;

namespace Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new clock
            Clock theClock = new Clock();

            // Create the display and tell it to
            // subscribe to the clock just created
            /*
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);
            */
            theClock.SecondChange += (o, t) =>
            {
                Console.WriteLine("Hora: {0}:{1}:{2}",t.hour,t.minute,t.second);
            };
            theClock.SecondChange += (o, t) =>
            {
                Console.WriteLine("Escribimos en log: {0}:{1}:{2}", t.hour, t.minute, t.second);
            };
            /*
            DisplayFifteenChange displayFifteen = new DisplayFifteenChange();
            displayFifteen.Suscribe(theClock);
            */
            theClock.FifteenChange += (o, t) =>
            {
                Console.WriteLine("Han pasado 15 segundos");
            };

            // Create a Log object and tell it
            // to subscribe to the clock


            // Get the clock started
            theClock.Run();
        }
    }
}
