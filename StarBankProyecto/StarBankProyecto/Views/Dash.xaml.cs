﻿using System;
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

            Bienvenida.Text = "Bienvenido " + Nombre;
        }

        private async void PageAdminCuentas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.AdminCuentas());
        }
    }
}