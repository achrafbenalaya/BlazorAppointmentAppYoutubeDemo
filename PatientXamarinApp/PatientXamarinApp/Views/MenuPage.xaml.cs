using PatientXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientXamarinApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {

                new HomeMenuItem {Id = MenuItemType.Appointment, Title="Appointment", },
                new HomeMenuItem {Id = MenuItemType.Doctor, Title="Doctor" },
                new HomeMenuItem {Id = MenuItemType.Patient, Title="Patient" },
                new HomeMenuItem {Id = MenuItemType.Experience, Title="Experience" },
                new HomeMenuItem {Id = MenuItemType.Department, Title="Department" },
                new HomeMenuItem {Id = MenuItemType.Gender, Title="Gender" },
                new HomeMenuItem {Id = MenuItemType.BloodGroup, Title="BloodGroup" },
                //new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}