using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientXamarinApp.Services;
using PatientXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DoctorsPage : ContentPage
    {
        private List<Models.Genders> _Genders;
        private List<Models.Departments> _Departments;
        private List<Models.Experience> _Experience;
        private DataServices _dataServices = new DataServices();
        public DoctorsPage()
        {
            var TheViewModel = new DoctorViewModel();

            BindingContext = TheViewModel;

            InitializeComponent();


            var task = Task.Run(async () => await _dataServices.GetGenders());
            _Genders = task.Result;
            var task2 = Task.Run(async () => await _dataServices.GetDepartments());
            _Departments = task2.Result;

            var task3 = Task.Run(async () => await _dataServices.GetExperience());
            _Experience = task3.Result;
        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddDoctorPage(_Genders, _Departments, _Experience));
        }

        private void DoctorsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var _doctors = e.Item as Models.Doctors;
            Navigation.PushAsync(new EditDoctorPage(_doctors));
        }
    }
}