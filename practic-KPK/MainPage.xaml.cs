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
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            MessagingCenter.Subscribe<EventArgs>(this, "OpenMenu", args =>
            {
                IsPresented = !IsPresented;
            });
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void MenuBTN_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(EventArgs.Empty, "OpenMenu");
        }
        private void MenuBTN_Clicked1(object sender, EventArgs e)
        {
            MessagingCenter.Send(EventArgs.Empty, "OpenMenu");
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
