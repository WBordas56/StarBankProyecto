using ProyectoFinal.Api;
using ProyectoFinal.Models;
using StarBankProyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarBankProyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilUsuario : ContentPage
    {

        /*
        
        Usuario pusuario;
        Dolar pdolar;

        public PerfilUsuario()
        {
            InitializeComponent();
        }
        */

        public string obtenerFecha(string fecha)
        {
            var _fecha = DateTime.Parse(fecha);
            string mes = "";

            switch (_fecha.Month)
            {
                case 1:
                    mes = "enero";
                    break;
                case 2:
                    mes = "febrero";
                    break;
                case 3:
                    mes = "marzo";
                    break;
                case 4:
                    mes = "abril";
                    break;
                case 5:
                    mes = "mayo";
                    break;
                case 6:
                    mes = "junio";
                    break;
                case 7:
                    mes = "julio";
                    break;
                case 8:
                    mes = "agosto";
                    break;
                case 9:
                    mes = "septiembre";
                    break;
                case 10:
                    mes = "octubre";
                    break;
                case 11:
                    mes = "noviembre";
                    break;
                case 12:
                    mes = "diciembre";
                    break;
            }

            return _fecha.Day + " de " + mes + " del " + _fecha.Year;
        }

        public string ocultarContraseña(string contra)
        {
            string clave = "";

            for (int i = 0; i < contra.Length; i++)
            {
                clave += "* ";
            }

            clave.Remove(contra.Length - 1);

            return clave;
        }


        private async void frmsexo_Tapped(object sender, EventArgs e)
        {
            if (btneditar.Text == "LISTO")
            {
                string action = await DisplayActionSheet("Sexo", "Cancelar", null, "Masculino", "Femenino");
                sexo.Text = action;
            }
        }

    }
}