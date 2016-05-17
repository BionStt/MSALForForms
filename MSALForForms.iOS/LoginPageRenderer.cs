using Microsoft.Identity.Client;
using MSALForForms.iOS;
using MSALForForms.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(Login), typeof(LoginPageRenderer))]
namespace MSALForForms.iOS
{
    class LoginPageRenderer : PageRenderer
    {
        Login page;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            page = e.NewElement as Login;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            page.PlatformParameters = new PlatformParameters(this);

        }
    }
}