using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
   public class EditDoctorViewModel
    {

        public Doctors TheSelectedDoctor { get; set; }
        private DataServices _dataServices = new DataServices();

        public ICommand EditDoctorCommand => new Command(async () =>

        {
            TheSelectedDoctor.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PutDoctors(TheSelectedDoctor.DoctorsId, TheSelectedDoctor);


        });

        public ICommand DeleteDoctorCommand => new Command(async () =>

        {
            await _dataServices.DeleteDoctor(TheSelectedDoctor.DoctorsId);
        });




    }
}
