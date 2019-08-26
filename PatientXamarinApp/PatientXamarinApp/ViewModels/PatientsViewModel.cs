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

        //private List<Models.Genders> _Genders;
        //private List<Models.BloodGroups> _BloodGroups;


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


        //public List<Genders> _GendersList
        //{
        //    get { return _Genders; }
        //    set
        //    {

        //        _Genders = value;

        //        OnPropertyChanged();

        //    }

        //}
        //public List<BloodGroups> _BloodGroupsList
        //{
        //    get { return _BloodGroups; }
        //    set
        //    {

        //        _BloodGroups = value;

        //        OnPropertyChanged();

        //    }

        //}

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

            //var task = Task.Run(async () => await _dataServices.GetGenders());
            //_GendersList = task.Result;

            //var task2 = Task.Run(async () => await _dataServices.GetBloodGroup());
            //_BloodGroupsList = task2.Result;

        }

      





    }
}
