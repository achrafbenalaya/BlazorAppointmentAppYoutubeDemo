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
    public partial class testpicker : ContentPage
    {
        public testpicker()
        {
            var monkeyList = new List<string>();
            monkeyList.Add("Baboon");
            monkeyList.Add("Capuchin Monkey");
            monkeyList.Add("Blue Monkey");

           
            //PickerGender.ItemsSource = monkeyList;
            InitializeComponent();
            monkito.ItemsSource = monkeyList.ToList();
        }
    }
}