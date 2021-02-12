using System;
using ToDo.App.Data;
using ToDo.App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo.App
{
    public partial class App : Application
    {
        public static DataBaseContext Context { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDataBase();
            MainPage = new NavigationPage(new HomePage());
        }

        //Configuracion de Base de datos locales
        private void InitializeDataBase()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = System.IO.Path.Combine(folderApp, "ToDo.db3");
            Context = new DataBaseContext(dbPath);
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
