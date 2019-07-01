using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Esperanza
{
    public partial class App : Application
    {
        static DBase _dbase;
        public static DBase DBase
        {
            get
            {
                if (_dbase == null)
                {
                    _dbase = new DBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ELA.db3"));
                }
                return _dbase;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new MenuPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
