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
    public partial class AdminCuentas : ContentPage
    {
        public AdminCuentas()
        {
            InitializeComponent();
        }

        private async void saldo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.VerSaldos());

        }

        private async void Transferencias_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Transacciones_Mes());

        }

        private async void Historial_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.VerHisorial());

        }
    }
}