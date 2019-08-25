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
    public partial class DepartmentsPage : ContentPage
    {
        public DepartmentsPage()
        {
            InitializeComponent();
        }

        private async void DepartmentsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var _departments = e.Item as Models.Departments;
            Navigation.PushAsync(new EditDepartmentsPage(_departments));
        }

        private async void GoToAddDept(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddDepartmentsPage());
        }
    }
}