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
    public partial class ExperiencePage : ContentPage
    {
        public ExperiencePage()
        {
            InitializeComponent();
        }

        private async void GoToAddExperience(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExperiencePage());
        }

        private  void ExperienceListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var _Experience = e.Item as Models.Experience;
            Navigation.PushAsync(new EditExperiencePage(_Experience));
        }
    }
}