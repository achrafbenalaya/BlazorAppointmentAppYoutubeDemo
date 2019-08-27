using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientXamarinApp.Models;
using PatientXamarinApp.Services;
using PatientXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddDoctorPage : ContentPage
    {
        private DataServices _dataServices = new DataServices();

        public AddDoctorPage(List<Models.Genders> genderses, List<Models.Departments> DepartmentsList, List<Models.Experience> ExperienceList)
        {
            var TheViewModel = new AddDoctorViewModel();

            BindingContext = TheViewModel;
            InitializeComponent();

            PickerGender.ItemsSource = genderses.ToList();
            ExperiencePicker.ItemsSource = ExperienceList.ToList();
            deptpicker.ItemsSource = DepartmentsList.ToList();
        }

        private async void SaveDoctor(object sender, EventArgs e)
        {
            Doctors NewDoctors = new Doctors();
            NewDoctors.FirstName = FirstName.Text;
            NewDoctors.LastName = LastName.Text;
            NewDoctors.PhoneNumber = Phone.Text;
            NewDoctors.Email = Email.Text;
            NewDoctors.Education = Education.Text;
            NewDoctors.Designation = "";
            NewDoctors.GendersId = Int32.Parse(GenderLabel.Text);
            NewDoctors.ExperienceId = Int32.Parse(pickerexp.Text);
            NewDoctors.DepartmentsId = Int32.Parse(DepartmentLabel.Text);
            NewDoctors.IsVisible =true ;
            NewDoctors.Urd = System.DateTime.Now.ToShortDateString();

            await _dataServices.PostDoctors(NewDoctors);


        }

        private void SelectedIndexChangeDepartment(object sender, EventArgs e)
        {
            var selectedId = (Models.Departments)deptpicker.SelectedItem;
            DepartmentLabel.Text = selectedId.DepartmentsId.ToString();
        }
        private void SelectedIndexChangegender(object sender, EventArgs e)
        {
            var selectedId = (Models.Genders)PickerGender.SelectedItem;
            GenderLabel.Text = selectedId.GendersId.ToString();
        }

        private void SelectedIndexChangeExperience(object sender, EventArgs e)
        {
            var selectedId = (Models.Experience)ExperiencePicker.SelectedItem;
            pickerexp.Text = selectedId.ExperienceId.ToString();
        }

    }
}