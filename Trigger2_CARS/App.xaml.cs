using System;
using Trigger2_CARS.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trigger2_CARS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Calculadora();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
