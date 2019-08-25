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
   public class PatientsViewModel : BaseViewModel
    {


        private List<Patients> _patients;
        private DataServices _dataServices = new DataServices();
        private bool _isRefresh;

        public List<Patients> _patientsList
        {
            get { return _patients; }
            set
            {

                _patients = value;
                
                OnPropertyChanged();

            }
        }

        public PatientsViewModel()
        {
            GetPatients();
        

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

        public ICommand GetPatientsCommand => new Command(async () =>

        {
            isRefresh = true;
            await GetPatients();
         
            isRefresh = false;
        });


        private async Task GetPatients()

        {
            _patientsList = await _dataServices.GetPatients();
            
        }

      





    }
}
