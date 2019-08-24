using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
   public class AddBloodGroupsViewModel
    {

        public BloodGroups TheSelectedBloodGroup { get; set; }
        private DataServices _dataServices = new DataServices();

        public AddBloodGroupsViewModel()
        {
            TheSelectedBloodGroup = new BloodGroups();
        }

        public ICommand SendBloodGroupsCommand => new Command(async () =>

        {
            TheSelectedBloodGroup.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PostBloodGroup(TheSelectedBloodGroup);
            //await Application.Current.MainPage.Navigation.PopAsync();
        });


    }
}
