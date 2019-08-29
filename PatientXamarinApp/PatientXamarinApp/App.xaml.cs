using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PatientXamarinApp.Services;
using PatientXamarinApp.Views;

namespace PatientXamarinApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
             MainPage = new MainPage();
         //  MainPage = new NavigationPage(new AppointmentsPage()); 
            //MainPage = new NavigationPage(new testpicker()); 
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
