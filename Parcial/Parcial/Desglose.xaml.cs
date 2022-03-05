using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Desglose : ContentPage
    {
        public Desglose()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cantidad.Text))
            {
                float can2 = float.Parse(cantidad.Text);
                int can, c200, c100, c50, c20, c10, c5, c1;
                c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;

                float cen50, cen25, cen10, cen5, cen1;
                cen50 = cen25 = cen10 = cen5 = cen1 = 0.00f;

                can = (int)can2;
                can2 = can2 - can;

                if ((can >= 200))
                {
                    c200 = (can / 200);
                    can = can - (c200 * 200);
                }
                if ((can >= 100))
                {
                    c100 = (can / 100);
                    can = can - (c100 * 100);
                }
                if ((can >= 50))
                {
                    c50 = (can / 50);
                    can = can - (c50 * 50);
                }
                if ((can >= 20))
                {
                    c20 = (can / 20);
                    can = can - (c20 * 20);
                }
                if ((can >= 10))
                {
                    c10 = (can / 10);
                    can = can - (c10 * 10);
                }
                if ((can >= 5))
                {
                    c5 = (can / 5);
                    can = can - (c5 * 5);
                }
                if ((can >= 1))
                {
                    c1 = (can / 1);
                    can = can - c1;
                }

                if ((can2 >= 0.50))
                {
                    cen50 = 1;
                    can2 = (can2 - 0.50f);
                }
                if ((can2 >= 0.25))
                {
                    cen25 = 1;
                    can2 = (can2 - 0.25f);
                }
                if ((can2 >= 0.10))
                {
                    cen10 = (can2 - (can2 % 0.10f)) / 0.10f;
                    can2 = (can2 % 0.10f);
                    cen10 = (float)Math.Round(cen10, 2);
                }
                if ((can2 >= 0.05))
                {
                    cen5 = (can2 - (can2 % 0.05f)) / 0.05f;
                    can2 = can2 - (cen5 % 0.05f);
                    cen5 = (float)Math.Round(cen5, 2);
                }
                if ((can2 >= 0.01))
                {
                    cen1 = (can2 / 0.01f);
                    cen1 = (float)Math.Round(cen1, 2);
                }

                doscientos.Text = ($"Billetes de 200: {c200}");
                cien.Text = ($"Billetes de 100: {c100}");
                cincuenta.Text = ($"Billetes de 50: {c50}");
                veinte.Text = ($"Billetes de 20: {c20}");
                diez.Text = ($"Billetes de 10: {c10}");
                cinco.Text = ($"Billetes de 5: {c5}");
                uno.Text = ($"Billetes de 1: {c1}");
                cencincuenta.Text = ($"Monedas de 50 centavos: {cen50}");
                cenveinticinco.Text = ($"Monedas de 25 centavos: {cen25}");
                cendiez.Text = ($"Monedas de 10 centavos: {cen10}");
                cencinco.Text = ($"Monedas de 5 centavos: {cen5}");
                cenuno.Text = ($"Monedas de 1 centavos: {cen1}");
            }
            else
            {
                DisplayAlert("Datos Erroneos", "Por favor ingresa la información primero", "Ok");
            }

            
        }
    }
}