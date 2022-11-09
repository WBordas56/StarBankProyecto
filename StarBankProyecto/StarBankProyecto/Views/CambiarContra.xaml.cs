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
    public partial class CambiarContra : ContentPage
    {
        public CambiarContra()
        {
            InitializeComponent();
        }

        public async void Guardar(Object sender, EventArgs e)
        {
            //Agregar metodo para cambiar la contraseña en la base de dato con todas las validaciones y luego regresar al login del inicio
            await Navigation.PushAsync(new MainPage());
            
        }
    }
}