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
   public class GendersViewModel :BaseViewModel
    {
        private List<Genders> _genders1;
        private  DataServices _dataServices = new DataServices();
        private bool _isRefresh;


        public List<Genders> _genders
        {
            get { return _genders1;}
            set  {

            _genders1 = value;
            OnPropertyChanged();

                }
            }

        public GendersViewModel()
        {
            GetGenders();
            
        }

        public bool isRefresh
        {
            get {return _isRefresh; }
            set
            {
                _isRefresh = value;
                OnPropertyChanged();
            } 
        }

        public ICommand GetGendersCOmmand => new Command(async () =>

        {
            isRefresh = true;
            await GetGenders();
            isRefresh = false;
        });


        private async Task GetGenders()

        {
            _genders = await _dataServices.GetGenders();

        }







    }
}
