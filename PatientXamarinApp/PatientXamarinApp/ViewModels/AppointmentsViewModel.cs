using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
   public class AppointmentsViewModel : BaseViewModel
    {


        private List<Appointment> _Appointment;
        private DataServices _dataServices = new DataServices();
        private bool _isRefresh;

        public List<Appointment> _AppointmentList
        {
            get { return _Appointment; }
            set
            {

                _Appointment = value;

                OnPropertyChanged();

            }
        }


        public AppointmentsViewModel()
        {
            GetAppointments();


        }

        public bool isRefresh
        {
            get { return _isRefresh; }
            set
            {
                _isRefresh = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetAppointmentCommand => new Command(async () =>

        {
            isRefresh = true;
            await GetAppointments();

            isRefresh = false;
        });


        private async Task GetAppointments()

        {
            _AppointmentList = await _dataServices.GetAppointment();

        }






















    }
}
