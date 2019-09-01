using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using PatientXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PatientsPage : ContentPage
    {
        private List<Models.Genders> _Genders;
        private List<Models.BloodGroups> _BloodGroups;
        private DataServices _dataServices = new DataServices();
        public PatientsPage()
        {
            var TheViewModel = new PatientsViewModel();

            BindingContext = TheViewModel;
            
            InitializeComponent();
            var task = Task.Run(async () => await _dataServices.GetGenders().ConfigureAwait(false));
            _Genders = task.Result;
            var task2 = Task.Run(async () => await _dataServices.GetBloodGroup().ConfigureAwait(false));
            _BloodGroups = task2.Result;

        }

        private async void GoToAddPatients(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new AddPatientPage(_Genders, _BloodGroups));
        }

        private void PatientsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var _Patient = e.Item as Models.Patients;
            Navigation.PushAsync(new EditPatientsPage(_Patient));
        }

    
        //private async Task GetGendersandBlood()

        //{
        //    _Genders = await _dataServices.GetGenders();
        //    _BloodGroups = await _dataServices.GetBloodGroup();
        //}



    }
}