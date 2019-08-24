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
    public partial class Genders : ContentPage
    {
        public Genders()
        {
            InitializeComponent();
            
        }


        private async void GoToAddGender(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddGender());
        }

        private void GenderListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
          var _Genders=  e.Item as Models.Genders;
          Navigation.PushAsync(new EditGenders(_Genders));
        }
    }
}