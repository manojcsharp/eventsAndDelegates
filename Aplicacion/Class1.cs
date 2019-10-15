using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion
{
    class DisplayFifteenChange
    {
        public void Suscribe(Clock theClock)
        {
            theClock.FifteenChange += new Clock.FifteenChangeHandler(OnFifteenChange);
        }

        public void OnFifteenChange(Object o, EventArgs e)
        {
            Console.WriteLine("15 Segundos");
        }
    }
}
