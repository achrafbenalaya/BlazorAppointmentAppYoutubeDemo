using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
   public class AddAppointmentViewModel
    {
        public Appointment TheSelectedAppointment { get; set; }
        private DataServices _dataServices = new DataServices();

        public AddAppointmentViewModel()
        {
            TheSelectedAppointment = new Appointment();
        }


        public ICommand SendAppointmentCommand => new Command(async () =>

        {
            TheSelectedAppointment.Urd = System.DateTime.Now.ToShortDateString();

            await _dataServices.PostAppointment(TheSelectedAppointment);

        });


    }
}
