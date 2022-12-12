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
    public partial class Dash : ContentPage
    {
        public Dash(string Nombre)
        {
            InitializeComponent();

            Bienvenida.Text = "Bienvenido(a) " + Nombre;
        }

        private async void PageAdminCuentas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.AdminCuentas());
        }

        private async void PageServicios(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Servicios());
        }

        private async void PageTransfer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Transferencias());
        }

        private async void PagePresupuesto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ControlPresupuestario());
        }
        private async void PagePefil(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PerfilUsuario());
        }

        private async void PageDesarrolladores(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Transferencias());
        }

        private async void PageSalir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ControlPresupuestario());
        }
    }
}