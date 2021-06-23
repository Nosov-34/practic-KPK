using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using practic_KPK.Pages;

namespace practic_KPK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
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

        }
    }
}
