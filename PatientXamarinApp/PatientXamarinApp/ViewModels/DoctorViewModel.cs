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
  public class DoctorViewModel : BaseViewModel
    {


        private List<Doctors> _doctors;
        private DataServices _dataServices = new DataServices();
        private bool _isRefresh;

        public List<Doctors> _doctorsList
        {
            get { return _doctors; }
            set
            {

                _doctors = value;

                OnPropertyChanged();

            }
        }


        public DoctorViewModel()
        {
            GetDoctors();


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

        public ICommand GetDoctorsCommand => new Command(async () =>

        {
            isRefresh = true;
            await GetDoctors();

            isRefresh = false;
        });


        private async Task GetDoctors()

        {
            _doctorsList = await _dataServices.GetDoctors();

        }


    }
}
