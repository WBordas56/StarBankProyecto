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
            await Navigation.PushAsync(new Views.Dash());
        }
        private async void forgetPass(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.OlvideContra());

        }
    }
}
