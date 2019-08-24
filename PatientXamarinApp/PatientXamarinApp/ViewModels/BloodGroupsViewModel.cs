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
   public class BloodGroupsViewModel : BaseViewModel
    {

        private List<BloodGroups> theBloodGroups;
        private DataServices _dataServices = new DataServices();
        private bool _isRefresh;


        public List<BloodGroups> _BloodGroups
        {
            get { return theBloodGroups; }
            set
            {

                theBloodGroups = value;
                OnPropertyChanged();

            }
        }

        public BloodGroupsViewModel()
        {
            GetBloodGroups();

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

        public ICommand GetBloodGroupsCommand => new Command(async () =>

        {
            isRefresh = true;
            await GetBloodGroups();
            isRefresh = false;
        });


        private async Task GetBloodGroups()

        {
            _BloodGroups = await _dataServices.GetBloodGroup();

        }








    }
}
