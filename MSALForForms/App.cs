using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Microsoft.Identity.Client;
using MSALForForms.Pages;
using Xamarin.Forms;

namespace MSALForForms
{
    public class App : Application
    {
        public static PublicClientApplication ClientApplication { get; set; }
        public static string[] Scopes = { "User.Read" };
        public App()
        {
            ClientApplication = new PublicClientApplication("a956cd3b-8dee-4067-9274-732689b86bb8");
            var content = new Login();
            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
