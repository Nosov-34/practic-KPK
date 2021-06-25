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
    public partial class ProfPage : ContentPage
    {
        public ProfPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page1B());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page0A());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page2C());
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page3D());
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page4E());
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page5F());
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page6G());
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page7H());
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page8I());
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page9J());
        }

        private void TapGestureRecognizer_Tapped_10(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page10K());
        }

        private void TapGestureRecognizer_Tapped_11(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page11L());
        }

        private void Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
