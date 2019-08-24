using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
    public class DepartmentsViewModel : BaseViewModel
    {

        private List<Departments> _Departments;
        private DataServices _dataServices = new DataServices();
        private bool _isRefresh;


        public List<Departments> _DepartmentsList
        {
            get { return _Departments; }
            set
            {

                _Departments = value;
                OnPropertyChanged();

            }
        }

        public DepartmentsViewModel()
        {
            GetDepartments();

        }

        public bool isRefresh
        {
            get { return _isRefresh; }
            set
            {
                _isRefresh = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetDepartmentsCommand => new Command(async () =>

        {
            isRefresh = true;
            await GetDepartments();
            isRefresh = false;
        });


        private async Task GetDepartments()

        {
            _DepartmentsList = await _dataServices.GetDepartments();

        }


    }
}
