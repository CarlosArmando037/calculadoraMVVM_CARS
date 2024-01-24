using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xamarin.Forms;

namespace Trigger2_CARS.Triggers
{
    internal class Tcolor : TriggerAction<Button>
    {
        private static Button botonselec = null;
        public string color = "#2288bb";
        protected override void Invoke(Button btn)
        {
            if (botonselec != null)
            {
                botonselec.BackgroundColor = Color.CornflowerBlue;
            }
            if(btn.ClassId == "operador")
            {
                botonselec = btn;
               btn.BackgroundColor = Color.Green;
            } 
        }
    }
}
