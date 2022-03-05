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
    public partial class DesgloseDolares : ContentPage
    {
        public DesgloseDolares()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cantidad.Text))
            {
                float can2 = float.Parse(cantidad.Text);

                await Navigation.PushAsync(new ResultadoDolares(can2));
            }
            else
            {
                DisplayAlert("Datos Erroneos", "Por favor ingresa la información primer", "Ok");
            }
        }
    }
}