﻿using MauiAppMinhasCompras.Helpers;
using System.Globalization;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {

        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"banco_sqlite_compras.db3"
                        );

                    _db = new SQLiteDatabaseHelper(".... db3");
                }

                return _db;
            }

        }

        public static object Database { get; internal set; }

        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        }

        
    }
}
