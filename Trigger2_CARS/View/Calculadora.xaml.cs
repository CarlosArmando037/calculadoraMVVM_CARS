using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trigger2_CARS.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trigger2_CARS.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        public Calculadora()
        {
            InitializeComponent();
            BindingContext = new VMcalculadora(Navigation);
        }

    }
}