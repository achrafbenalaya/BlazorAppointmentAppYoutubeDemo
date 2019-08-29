using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
  public  class EditAppointmentViewModel
    {
        public Appointment TheSelectedAppointments { get; set; }
        private DataServices _dataServices = new DataServices();

        public ICommand EditAppointmentCommand => new Command(async () =>

        {
            TheSelectedAppointments.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PutAppointment(TheSelectedAppointments.AppointmentId, TheSelectedAppointments);


        });

        public ICommand DeleteAppointmentCommand => new Command(async () =>

        {
            await _dataServices.DeleteAppointment(TheSelectedAppointments.AppointmentId);
        });


    }
}
