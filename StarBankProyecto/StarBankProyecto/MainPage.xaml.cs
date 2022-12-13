using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StarBankProyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Ingresar(Object sender, EventArgs e)
        {
            if (txtUser.Text == null || txtUser.Text == "") 
            { 
                await DisplayAlert("Aviso", "Ingrese un usuario", "OK"); 
            }
            else
            {
                await Navigation.PushAsync(new Views.Dash("Jose Manuel"));
            }


            
        }
        private async void forgetPass(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.OlvideContra());

        }
    }
}
