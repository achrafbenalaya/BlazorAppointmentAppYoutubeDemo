using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
     public  class AddDepartmentsViewModel
    {
        public Departments TheSelectedDepartments { get; set; }
        private DataServices _dataServices = new DataServices();

        public AddDepartmentsViewModel()
        {
            TheSelectedDepartments = new Departments();
        }



        public ICommand SendDepartmentsCommand => new Command(async () =>

        {
            TheSelectedDepartments.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PostDepartments(TheSelectedDepartments);
            //await Application.Current.MainPage.Navigation.PopAsync();
        });



    }
}
