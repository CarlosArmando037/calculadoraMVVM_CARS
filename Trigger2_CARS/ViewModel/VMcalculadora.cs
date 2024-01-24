using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Trigger2_CARS.ViewModel
{
    public class VMcalculadora : BaseViewModel
    {
        #region VARIABLES
        int _num0 = 0;
        int _num1 =1;
        int _num2=2;
        int _num3=3;
        int _num4=4;
        int _num5=5;
        int _num6=6;
        int _num7=7;
        int _num8=8;
        int _num9=9;
        bool _suma;
        bool _resta;
        bool _multiplicacion;
        bool _divicion;
        string _resultado;
        int _variable1;
        int _varAux;
        int _borrar;
        #endregion
        #region CONSTRUCTOR
        public VMcalculadora(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        //numeros
        public int Num0
        {
            get { return _num0; }
            set { SetProperty(ref _num0, value); }
        }
        public int Num1
        {
            get { return _num1; }
            set { SetProperty(ref _num1, value); }
        }
        public int Num2
        {
            get { return _num2; }
            set { SetProperty(ref _num2, value); }
        }
        public int Num3
        {
            get { return _num3; }
            set { SetProperty(ref _num3, value); }
        }
        public int Num4
        {
            get { return _num4; }
            set { SetProperty(ref _num4, value); }
        }
        public int Num5
        {
            get { return _num5; }
            set { SetProperty(ref _num5, value); }
        }
        public int Num6
        {
            get { return _num6; }
            set { SetProperty(ref _num6, value); }
        }
        public int Num7
        {
            get { return _num7; }
            set { SetProperty(ref _num7, value); }
        }
        public int Num8
        {
            get { return _num8; }
            set { SetProperty(ref _num8, value); }
        }
        public int Num9
        {
            get { return _num9; }
            set { SetProperty(ref _num9, value); }
        }
        //operaciones
        public bool Suma
        {
            get { return _suma; }
            set { SetProperty(ref _suma, value); }
        }
        public bool Resta
        {
            get { return _resta; }
            set { SetProperty(ref _resta, value); }
        }
        public bool Divicion
        {
            get { return _divicion; }
            set { SetProperty(ref _divicion, value); }
        }
        public bool Multiplicacion
        {
            get { return _multiplicacion; }
            set { SetProperty(ref _multiplicacion, value); }
        }
        public int Variable1
        {
            get { return _variable1; }
            set { SetProperty(ref _variable1, value); }
        }
        public int varAux
        {
            get { return _varAux; }
            set { SetProperty(ref _varAux, value); }
        }
        public string Resultado
        {
            get { return _resultado; }
            set { SetProperty(ref _resultado, value); }
        }
        public int Borrar
        {
            get { return _borrar; }
            set { SetProperty(ref _borrar, value); }
        }
        #endregion
        #region PROCESOS
        //procesos numeros
        public void numero0()
        {
            Resultado += Num0;

        }
        public void numero1()
        {
            Resultado += Num1;
        }
        public void numero2()
        {
            Resultado += Num2;

        }
        public void numero3()
        {
            Resultado += Num3;

        }
        public void numero4()
        {
            Resultado += Num4;

        }
        public void numero5()
        {
            Resultado += Num5;

        }
        public void numero6()
        {
            Resultado += Num6;

        }
        public void numero7()
        {
            Resultado += Num7;

        }
        public void numero8()
        {
            Resultado += Num8;

        }
        public void numero9()
        {
            Resultado += Num9;

        }
        public void sumar()
        {
            if (varAux == 0)
            {
                varAux = Convert.ToInt32(Resultado);
            }
            else
            {
                Variable1 = Convert.ToInt32(Resultado);
            }
            Resultado = string.Empty;
            Suma = true;
            //Varible1 = 
        }
        public void restar()
        {
            if (varAux == 0)
            {
                varAux = Convert.ToInt32(Resultado);
            }
            else
            {
                Variable1 = Convert.ToInt32(Resultado);
            }
            Resultado = string.Empty;
            Resta = true;
            //Varible1 = 
        }
        public void multiplicar()
        {
            if (varAux == 0)
            {
                varAux = Convert.ToInt32(Resultado);
            }
            else
            {
                Variable1 = Convert.ToInt32(Resultado);
            }
            Resultado = string.Empty;
            Multiplicacion = true;
            //Varible1 = 
        }
        public void dividir()
        {
            if (varAux == 0)
            {
                varAux = Convert.ToInt32(Resultado);
            }
            else
            {
                Variable1 = Convert.ToInt32(Resultado);
            }
            Resultado = string.Empty;
            Divicion = true;
            //Varible1 = 
        }
        public void Erased()
        {
            Resultado = Resultado.Substring(0,Resultado.Length-1);

        }
        public void AC()
        {
            Variable1 = 0;
            varAux = 0;
            Resultado = string.Empty;
        }
        public void Igual()
        {
            if (Suma == true)
            {
                Variable1 = Convert.ToInt32(Resultado);
                Resultado = Convert.ToString(varAux + Variable1);
                varAux = Convert.ToInt32(Resultado);
                Suma = false;
            }
            else if (Resta ==true)
            {
                Variable1 = Convert.ToInt32(Resultado);
                Resultado = Convert.ToString(varAux - Variable1);
                varAux = Convert.ToInt32(Resultado);
                Resta = false;
            }
            else if (Divicion == true)
            {
                Variable1 = Convert.ToInt32(Resultado);
                Resultado = Convert.ToString(varAux / Variable1);
                varAux = Convert.ToInt32(Resultado);
                Divicion = false;
            }
            else if (Multiplicacion == true)
            {
                Variable1 = Convert.ToInt32(Resultado);
                Resultado = Convert.ToString(varAux * Variable1);
                varAux = Convert.ToInt32(Resultado);
                Multiplicacion = false;
            }
            else
            {

            }
        }
        #endregion
        #region COMANDOS
        public ICommand num1command => new Command(numero1);
        public ICommand num2command => new Command(numero2);
        public ICommand num3command => new Command(numero3);
        public ICommand num4command => new Command(numero4);
        public ICommand num5command => new Command(numero5);
        public ICommand num6command => new Command(numero6);
        public ICommand num7command => new Command(numero7);
        public ICommand num8command => new Command(numero8);
        public ICommand num9command => new Command(numero9);
        public ICommand num0command => new Command(numero0);
        public ICommand sumarcommand => new Command(sumar);
        public ICommand Igualcommand => new Command(Igual);
        public ICommand ACcommand => new Command(AC);
        public ICommand Ecommand => new Command(Erased);
        public ICommand restarcommand => new Command(restar);
        public ICommand multiplicarcommand => new Command(multiplicar);
        public ICommand dividircommand => new Command(dividir);


        #endregion
    }
}
