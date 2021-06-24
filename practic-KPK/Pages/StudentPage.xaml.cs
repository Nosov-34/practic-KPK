using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace practic_KPK.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class StudentPage : ContentPage
{
    public StudentPage()
    {
        InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page2());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page3());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page4());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page5());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page6());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}