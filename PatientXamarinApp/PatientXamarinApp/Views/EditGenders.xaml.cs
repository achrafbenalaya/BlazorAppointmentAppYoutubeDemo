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
    public partial class EditGenders : ContentPage
    {
        public EditGenders(Models.Genders _genders)
        {

            var EditViewModel = new EditGenderViewModel();
            EditViewModel.TheSelectedGender = _genders;
            BindingContext = EditViewModel;




            InitializeComponent();

           
        }
    }
}