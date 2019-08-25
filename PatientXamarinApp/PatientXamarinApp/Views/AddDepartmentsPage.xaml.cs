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
    public partial class AddDepartmentsPage : ContentPage
    {
        public AddDepartmentsPage()
        {
            InitializeComponent();
            AddedTimeStatic.Text = System.DateTime.Now.ToShortDateString();
        }


        private void SwitchVisible_OnToggled(object sender, ToggledEventArgs e)
        {
            IamVisible.IsChecked = !(IamVisible.IsChecked);
        }
    }
}