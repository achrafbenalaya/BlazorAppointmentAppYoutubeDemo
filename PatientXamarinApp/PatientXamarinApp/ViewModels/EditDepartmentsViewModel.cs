using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
   public class EditDepartmentsViewModel
    {


        public Departments TheSelectedDepartments { get; set; }
        private DataServices _dataServices = new DataServices();

        public ICommand EditDepartmentsCommand => new Command(async () =>

        {
            TheSelectedDepartments.Urd = System.DateTime.Now.ToShortDateString();
            await _dataServices.PutDepartments(TheSelectedDepartments.DepartmentsId, TheSelectedDepartments);

        });

        public ICommand DeleteDepartmentsCommand => new Command(async () =>

        {
            await _dataServices.DeleteDepartments(TheSelectedDepartments.DepartmentsId);

        });


    }
}
