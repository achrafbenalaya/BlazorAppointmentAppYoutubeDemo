using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
   public class EditExperienceViewModel
    {



        public Experience TheSelectedxperience { get; set; }
        private DataServices _dataServices = new DataServices();

        public ICommand EditExperienceCommand => new Command(async () =>

        {
            TheSelectedxperience.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PutExperience(TheSelectedxperience.ExperienceId, TheSelectedxperience);


        });

        public ICommand DeleteExperienceCommand => new Command(async () =>

        {
            await _dataServices.DeleteExperience(TheSelectedxperience.ExperienceId);

        });


    }
}
