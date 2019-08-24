using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientXamarinApp.Models;
using PatientXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditExperiencePage : ContentPage
    {
        public EditExperiencePage(Experience  experience)
        {


            var EditViewModel = new EditExperienceViewModel();
            EditViewModel.TheSelectedxperience = experience;
            BindingContext = EditViewModel;
            InitializeComponent();
        }
    }
}