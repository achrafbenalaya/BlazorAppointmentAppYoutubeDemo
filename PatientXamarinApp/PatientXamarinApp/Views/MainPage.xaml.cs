using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PatientXamarinApp.Models;

namespace PatientXamarinApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

         //   MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {

                    case (int)MenuItemType.Appointment:
                        MenuPages.Add(id, new NavigationPage(new AppointmentsPage()));
                        break;

                    case (int)MenuItemType.Doctor:
                        MenuPages.Add(id, new NavigationPage(new DoctorsPage()));
                        break;
                    case (int)MenuItemType.Patient:
                        MenuPages.Add(id, new NavigationPage(new PatientsPage()));
                        break;
                    case (int)MenuItemType.BloodGroup:
                        MenuPages.Add(id, new NavigationPage(new BloodGroupsPage()));
                        break;
                    case (int)MenuItemType.Department:
                        MenuPages.Add(id, new NavigationPage(new DepartmentsPage()));
                        break;
                    case (int)MenuItemType.Experience:
                        MenuPages.Add(id, new NavigationPage(new ExperiencePage()));
                        break;
                    case (int)MenuItemType.Gender:
                        MenuPages.Add(id, new NavigationPage(new Genders()));
                        break;

                    //case (int)MenuItemType.Browse:
                    //    MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                    //    break;

                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;


                    default:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}