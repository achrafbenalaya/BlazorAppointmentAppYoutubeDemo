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
    public partial class EditDoctorPage : ContentPage
    {
        public EditDoctorPage(Models.Doctors doctors)
        {

            var EditViewModel = new EditDoctorViewModel();
            EditViewModel.TheSelectedDoctor = doctors;
            BindingContext = EditViewModel;
            InitializeComponent();
        }
    }
}