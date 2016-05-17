using Android.App;
using Microsoft.Identity.Client;
using MSALForForms.Droid;
using MSALForForms.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Login), typeof(LoginPageRenderer))]
namespace MSALForForms.Droid
{
    public class LoginPageRenderer : PageRenderer
    {
        private Login _page;
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            _page = e.NewElement as Login;
            var activity = this.Context as Activity;
            _page.PlatformParameters = new PlatformParameters(activity);
        }
    }
}