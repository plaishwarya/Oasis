using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using App6.Android.Pages;

namespace App6.Android.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;

        // Event when the property value changes
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        private string password;
        public ICommand SubmitCommand { protected set; get; }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public INavigation Navigation { get; internal set; }

        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            if (email != "la" || password != "sec")
            {
                DisplayInvalidLoginPrompt();
            }
            else
            {
                 Navigation.PushAsync(new Pages.HomePage());
            }
        }
    }
}