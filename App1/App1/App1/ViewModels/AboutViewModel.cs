using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Обучение";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://docs.google.com/presentation/d/1UKbva7rfb7gTQXR8FsEEkWRk1EOSvZeuCxxEeXI6GMg/edit?usp=sharing"));
        }

        public ICommand OpenWebCommand { get; }
    }
}