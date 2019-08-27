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
    public partial class AppointmentsPage : ContentPage
    {
        private List<Models.Patients> _Patients;
        private List<Models.Departments> _Departments;
        private List<Models.Doctors> _Doctors;
        private DataServices _dataServices = new DataServices();
        public AppointmentsPage()
        {
            var TheViewModel = new AppointmentsViewModel();

            BindingContext = TheViewModel;
            InitializeComponent();


            //var task = Task.Run(async () => await _dataServices.GetGenders());
            //_Genders = task.Result;
            //var task2 = Task.Run(async () => await _dataServices.GetDepartments());
            //_Departments = task2.Result;

            //var task3 = Task.Run(async () => await _dataServices.GetExperience());
            //_Experience = task3.Result;
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AppointmentListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}