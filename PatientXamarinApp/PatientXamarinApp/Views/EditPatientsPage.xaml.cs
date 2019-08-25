using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPatientsPage : ContentPage
    {
        public EditPatientsPage(Models.Patients patients)
        {
            var EditViewModel = new EditPatientsViewModel();
            EditViewModel.TheSelectedPatient = patients;
            BindingContext = EditViewModel;
            InitializeComponent();
        }
    }
}