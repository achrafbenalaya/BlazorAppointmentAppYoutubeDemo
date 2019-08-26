using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
  public  class AddDoctorViewModel
    {

        public Doctors TheSelectedDoctor { get; set; }
        private DataServices _dataServices = new DataServices();

        public AddDoctorViewModel()
        {
            TheSelectedDoctor = new Doctors();
        }


        public ICommand SendPatientsCommand => new Command(async () =>

        {
            TheSelectedDoctor.Urd = System.DateTime.Now.ToShortDateString();
          
            await _dataServices.PostDoctors(TheSelectedDoctor);

        });






    }
}
