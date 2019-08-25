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
    public partial class EditDepartmentsPage : ContentPage
    {
        public EditDepartmentsPage(Models.Departments _departments)
        {
            var EditViewModel = new EditDepartmentsViewModel();
            EditViewModel.TheSelectedDepartments = _departments;
            BindingContext = EditViewModel;
            InitializeComponent();
        }
    }
}