using System;
using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace MSALForForms.Pages
{
    public partial class Login
    {
        public IPlatformParameters PlatformParameters { get; set; }
        public Login()
        {
            InitializeComponent();
            LoginButton.Clicked += LoginButton_Clicked;
        }
        protected override void OnAppearing()
        {
            App.ClientApplication.PlatformParameters = PlatformParameters;
            base.OnAppearing();
        }
        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                AuthenticationResult ar = await App.ClientApplication.AcquireTokenAsync(App.Scopes);
                WelcomeText.Text = $"Welcome {ar.User.Name}";
            }
            catch (MsalException ex)
            {
                WelcomeText.Text = ex.Message;
            }
        }
    }
}