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
public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void MenuBTN_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void KorpBTN_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Corps());
        }

        private void SpecBTN_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ProfPage());
        }

        private void StudentBTN_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new StudentPage());
        }

        private void VKBTN_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://vk.com/koppk174"));
        }

        private void InternetBTN_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://kpk74.ru/ru"));
        }
    }
}