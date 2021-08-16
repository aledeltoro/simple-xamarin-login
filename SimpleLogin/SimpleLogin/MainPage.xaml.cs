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
            bool isEmailEmpty = string.IsNullOrEmpty(email.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(password.Text);
            bool areFieldsFull = !isEmailEmpty && !isPasswordEmpty;

            if (areFieldsFull)
            {
                await DisplayAlert("Welcome!", $"Hey {email.Text}!", "Ok");
            }

            if (isEmailEmpty)
            {
                await DisplayAlert("Error", "Campo email cannot be empty", "Ok");
            }

            if (isPasswordEmpty)
            {
                await DisplayAlert("Error", "Campo password cannot be empty", "Ok");
            }
        }
    }
}
