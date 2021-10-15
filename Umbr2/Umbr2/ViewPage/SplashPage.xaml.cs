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
    public partial class SplashPage : ContentPage
    {
        Image splashImage;
        public SplashPage()
        {
            InitializeComponent();

            splashImage = new Image
            {
                Source = "ninedigit.jpg"
            };

            Stacker.Children.Add(splashImage);
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();
            /*await splashImage.ScaleTo(10, 2000); // Time consuming process such as initiation
            await splashImage.ScaleTo(20, 800, Easing.Linear);
            await splashImage.ScaleTo(90, 1200, Easing.Linear);
            await splashImage.ScaleTo(120, 1000, Easing.Linear);
            await splashImage.ScaleTo(45, 1200, Easing.Linear);
            await splashImage.ScaleTo(15, 1500, Easing.Linear);*/
            await splashImage.ScaleTo(0, 1200, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new HomePage());
        }

    }
}