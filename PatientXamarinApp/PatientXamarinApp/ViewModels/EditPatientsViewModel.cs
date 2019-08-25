using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
   public class EditPatientsViewModel
    {

        public Patients TheSelectedPatient { get; set; }
        private DataServices _dataServices = new DataServices();

        public ICommand EditPatientsCommand => new Command(async () =>

        {
            TheSelectedPatient.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PutPatients(TheSelectedPatient.PatientsId, TheSelectedPatient);


        });

        public ICommand DeletePatientsCommand => new Command(async () =>

        {
            await _dataServices.DeletePatients(TheSelectedPatient.PatientsId);
        });


    }
}
