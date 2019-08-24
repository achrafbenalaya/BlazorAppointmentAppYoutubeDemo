using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BloodGroupsPage : ContentPage
    {
        public BloodGroupsPage()
        {
            InitializeComponent();
        }

        private async void GoToAddBloodGroups(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddBloodGroupsPage());
        }


        private void BloodGListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var _BloodGroups = e.Item as Models.BloodGroups;
            Navigation.PushAsync(new EditBloodGroupsPage(_BloodGroups));
        }
    }
}