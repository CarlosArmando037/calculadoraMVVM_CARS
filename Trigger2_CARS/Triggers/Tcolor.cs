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
        protected override void Invoke(Button btn)
        {
            btn.BackgroundColor = Color.Green;

        }
    }
}
