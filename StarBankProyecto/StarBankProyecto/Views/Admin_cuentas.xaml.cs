using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarBankProyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin_cuentas : ContentPage
    {
        public Admin_cuentas()
        {
            InitializeComponent();
        }

        private async void saldos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Versaldo_Corrientes());
        }

        private async void historial_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Historial_transac());
        }

        private async void transc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Transacciones_Mes());

        }
    }
}