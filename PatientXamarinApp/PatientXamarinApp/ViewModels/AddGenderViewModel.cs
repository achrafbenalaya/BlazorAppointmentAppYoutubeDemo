using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientXamarinApp.ViewModels
{
    public class AddGenderViewModel
    {
        public Genders TheSelectedGender { get; set; }
        private DataServices _dataServices = new DataServices();

        public AddGenderViewModel()
        {
            TheSelectedGender = new Genders();
        }



        public ICommand sendGendersCOmmand => new Command(async () =>

        {
            TheSelectedGender.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PostGenders(TheSelectedGender);
            await Application.Current.MainPage.Navigation.PopAsync();
        });


    }
}
