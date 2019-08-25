using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
  public class AddPatientsViewModel
    {


        public Patients TheSelectedPatient { get; set; }
        private DataServices _dataServices = new DataServices();

        public AddPatientsViewModel()
        {
            TheSelectedPatient = new Patients();
        }


        public ICommand SendPatientsCommand => new Command(async () =>

        {
            TheSelectedPatient.Urd = System.DateTime.Now.ToShortDateString();
            TheSelectedPatient.BloodGroupsId = (int)TheSelectedPatient.BloodGroupsId;
            TheSelectedPatient.GendersId= (int)(TheSelectedPatient.GendersId);
            await _dataServices.PostPatients(TheSelectedPatient);
           
        });


    }
}
