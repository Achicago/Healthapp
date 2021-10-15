using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Umbr2.ViewPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            // NavigationPage.SetHasNavigationBar(this, false);
        }

        private void foodDiet(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DietPage());
        }

        /* private void LoginUserPage(object sender, EventArgs e)
         {
            // Application.Current.MainPage = new NavigationPage(new LoginUserPage());
         }*/

        /*private void UserRider(object sender, EventArgs e)
        {
            // Application.Current.MainPage = new NavigationPage(new UserRiderPickerPage());
        }*/

    }
}