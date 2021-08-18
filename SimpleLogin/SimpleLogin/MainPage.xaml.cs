using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClick(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);
            bool areFieldsFull = !isEmailEmpty && !isPasswordEmpty;

            if (areFieldsFull)
            {
                await DisplayAlert("Welcome!", $"Hey {emailEntry.Text}!", "Ok");
                return;
            }

            if (isEmailEmpty)
            {
                await DisplayAlert("Error", "Field 'email' cannot be empty", "Ok");
            }

            if (isPasswordEmpty)
            {
                await DisplayAlert("Error", "Field 'password' cannot be empty", "Ok");
            }
        }
    }
}
