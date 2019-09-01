using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
  public  class EditGenderViewModel
    {
        public Genders TheSelectedGender { get; set; }
        private DataServices _dataServices = new DataServices();

        public ICommand EditGendersCOmmand => new Command(async () =>

        {
            TheSelectedGender.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PutGenders(TheSelectedGender.GendersId, TheSelectedGender);

        });



        public ICommand DeleteGendersCOmmand => new Command(async () =>

        {
           
            await _dataServices.DeleteGenders(TheSelectedGender.GendersId);


        });

    }
}
