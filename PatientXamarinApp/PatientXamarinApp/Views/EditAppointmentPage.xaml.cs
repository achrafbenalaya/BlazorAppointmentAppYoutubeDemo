using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using achraf.Shared.Models;
using PatientXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Appointment = PatientXamarinApp.Models.Appointment;

namespace PatientXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditAppointmentPage : ContentPage
    {
        public EditAppointmentPage(Appointment appointment)
        {
            var EditViewModel = new EditAppointmentViewModel();
            EditViewModel.TheSelectedAppointments = appointment;
            BindingContext = EditViewModel;
            InitializeComponent();
        }
    }
}