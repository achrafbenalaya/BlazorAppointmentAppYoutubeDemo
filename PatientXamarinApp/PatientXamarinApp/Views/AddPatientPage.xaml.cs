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
    public partial class AddPatientPage : ContentPage
    {
        private DataServices _dataServices = new DataServices();
        public AddPatientPage(List<Models.Genders> genderses, List<Models.BloodGroups> bloodGroupsesList)
        {

            var TheViewModel = new AddPatientsViewModel();

            BindingContext = TheViewModel;


            InitializeComponent();

            PickerGender.ItemsSource = genderses.ToList();
            PickerBlood.ItemsSource = bloodGroupsesList.ToList();

        }

        private void SwitchVisible_OnToggled(object sender, ToggledEventArgs e)
        {
            IamVisible.IsChecked = !(IamVisible.IsChecked);

        }


        private void PickerGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (PickerGender.SelectedIndex == -1)
            {
                BindingtheGender.Text = "ouuuuf";
            }
            else
            {
                var selectedId = (Models.Genders)PickerGender.SelectedItem;
                BindingtheGender.Text = selectedId.GendersId.ToString();
                //PickerGender.SelectedItem = selectedId.GendersId;
            }
        }

        private void PickerBlood_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            {
                var selectedId = (Models.BloodGroups)PickerBlood.SelectedItem;
                BindingthBloodItem.Text = selectedId.BloodGroupsId.ToString();
                //PickerBlood.SelectedItem = selectedId.BloodGroupsId;
            }
        }

        private async void SavePatient(object sender, EventArgs e)
        {
            Patients NewPatients = new Patients();
            NewPatients.Birthday = "";
            NewPatients.Email = "";
            NewPatients.FirstName = PatientEntry.Text;
            NewPatients.LastName = PatientEntryLastName.Text;
            NewPatients.PhoneNumber ="" ;
            NewPatients.Symptoms ="" ;
            NewPatients.BloodGroupsId =Int32.Parse(BindingthBloodItem.Text) ;
            NewPatients.GendersId = Int32.Parse(BindingtheGender.Text);
            NewPatients.IsVisible = bool.Parse(SwitchVisible.IsToggled.ToString());
            NewPatients.Urd = System.DateTime.Now.ToShortDateString();

          await _dataServices.PostPatients(NewPatients);


        }
    }
}