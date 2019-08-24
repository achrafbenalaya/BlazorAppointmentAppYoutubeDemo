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
    public partial class EditBloodGroupsPage : ContentPage
    {
        public EditBloodGroupsPage(Models.BloodGroups _BloodGroups)
        {
            var EditViewModel = new EditBloodGroupsViewModel();
            EditViewModel.TheSelectedBloodGroup = _BloodGroups;
            BindingContext = EditViewModel;

            InitializeComponent();
        }
    }
}