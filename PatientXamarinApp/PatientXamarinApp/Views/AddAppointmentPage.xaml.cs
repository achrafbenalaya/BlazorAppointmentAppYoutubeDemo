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
    public partial class AddAppointmentPage : ContentPage
    {
        private DataServices _dataServices = new DataServices();
        public AddAppointmentPage(List<Models.Patients> _Patients, List<Models.Departments> DepartmentsList, List<Models.Doctors> _Doctors)
        {
            var TheViewModel = new AddAppointmentViewModel();

            BindingContext = TheViewModel;

            InitializeComponent();

            DateName.MinimumDate = DateTime.Now;
            //DateName.MinimumDate = Convert.ToDateTime("1/1/1980");

            PatientName.ItemsSource = _Patients.ToList();
            DepartmentName.ItemsSource = DepartmentsList.ToList();
            DoctortName.ItemsSource = _Doctors.ToList();
        }


        private void SelectedIndexPatientChangegender(object sender, EventArgs e)
        {
            var selectedId = (Models.Patients)PatientName.SelectedItem;
            PatientPickerId.Text = selectedId.PatientsId.ToString();

            
        }

        private void SelectedIndexDepartmentChangegender(object sender, EventArgs e)
        {
            var selectedId = (Models.Departments)DepartmentName.SelectedItem;
            DepartmentPickerId.Text = selectedId.DepartmentsId.ToString();
        
        }

        private void SelectedIndexDoctorChangegender(object sender, EventArgs e)
        {
            var selectedId = (Models.Doctors)DoctortName.SelectedItem;
            DoctorPickerId.Text = selectedId.DoctorsId.ToString();
          
        }

        private async void PostAppointment(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment();
             newAppointment.Day = DateName.Date.ToShortDateString();
          //  newAppointment.Day = DateTime.Now.ToShortDateString();
            newAppointment.PatientsId = Int32.Parse(PatientPickerId.Text);
            newAppointment.DoctorsId = Int32.Parse(DoctorPickerId.Text); ;
            newAppointment.DepartmentsId = Int32.Parse(DepartmentPickerId.Text);
            newAppointment.Symptoms = SymptomsName.Text;
            newAppointment.Urd = System.DateTime.Now.ToShortDateString();
            newAppointment.IsVisible = true;

         
            await _dataServices.PostAppointment(newAppointment);


        }
    }
}