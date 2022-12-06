﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StarBankProyecto.Controllers;
using System.IO;

namespace StarBankProyecto
{
    public partial class App : Application
    {

        static DataBase db;

        public static DataBase DBase
        {
            get
            {
                if (db == null)
                {
                    String FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Starbank.db3");
                    db = new DataBase(FolderPath);
                }

                return db;
            }
        }







        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
