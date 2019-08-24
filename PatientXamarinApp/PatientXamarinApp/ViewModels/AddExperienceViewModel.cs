using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
  public  class AddExperienceViewModel
    {

        public Experience TheSelectedexperience { get; set; }
        private DataServices _dataServices = new DataServices();

        public AddExperienceViewModel()
        {
            TheSelectedexperience = new Experience();
        }



        public ICommand SendExperienceCommand => new Command(async () =>

        {
            TheSelectedexperience.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PostExperience(TheSelectedexperience);
            //await Application.Current.MainPage.Navigation.PopAsync();
           // await Application.Current.MainPage.Navigation.PopModalAsync();
        });


    }
}
