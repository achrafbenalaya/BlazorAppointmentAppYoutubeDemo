using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace PatientXamarinApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/achrafbenalaya?tab=repositories")));
            OpenWebYCommand = new Command(() => Device.OpenUri(new Uri("https://www.youtube.com/channel/UCsP8qtUrdi1o0s7HnGVDtYQ/videos")));
            OpenWebTCommand = new Command(() => Device.OpenUri(new Uri("https://twitter.com/AchrafBenAlaya")));
            OpenWebBCommand = new Command(() => Device.OpenUri(new Uri("https://achrafbenalayablog.azurewebsites.net")));
        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenWebYCommand { get; }
        public ICommand OpenWebTCommand { get; }
        public ICommand OpenWebBCommand { get; }
    }
}