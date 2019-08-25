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
        //private List<Models.Genders> _Genders;
        //private List<Models.BloodGroups> _BloodGroups;
        //private DataServices _dataServices = new DataServices();

        public AddPatientPage(List<Models.Genders> genderses, List<Models.BloodGroups> bloodGroupsesList)
        {
            //_Genders =  _dataServices.GetGenders();
            var TheViewModel = new AddPatientsViewModel();
            //var _BloodGroupss = new List<BloodGroups>();
            BindingContext = TheViewModel;

            //var monkeyList = new List<string>();
            //monkeyList.Add("Baboon");
            //monkeyList.Add("Capuchin Monkey");
            //monkeyList.Add("Blue Monkey");

            //PickerGender.ItemDisplayBinding = genderses.Select(x =>x.Name ).First();

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
                var selectedId = (Models.Genders) PickerGender.SelectedItem;
                BindingtheGender.Text = selectedId.GendersId.ToString();
                //PickerGender.SelectedItem = selectedId.GendersId;
            }
        }

        private void PickerBlood_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            {
                var selectedId = (Models.BloodGroups) PickerBlood.SelectedItem;
                BindingthBloodItem.Text = selectedId.BloodGroupsId.ToString();
                //PickerBlood.SelectedItem = selectedId.BloodGroupsId;
            }
        }
    }
}