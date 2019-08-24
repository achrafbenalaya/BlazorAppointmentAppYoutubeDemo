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
    public class ExperienceViewModel : BaseViewModel
    {

        private List<Experience> TheExperience;
        private DataServices _dataServices = new DataServices();
        private bool _isRefresh;


        public List<Experience> _Experience
        {
            get { return TheExperience; }
            set
            {

                TheExperience = value;
                OnPropertyChanged();

            }
        }

        public ExperienceViewModel()
        {
            GetExperience();

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

        public ICommand GetExperienceCommand => new Command(async () =>

        {
            isRefresh = true;
            await GetExperience();
            isRefresh = false;
        });


        private async Task GetExperience()

        {
            _Experience = await _dataServices.GetExperience();

        }



    }
}
