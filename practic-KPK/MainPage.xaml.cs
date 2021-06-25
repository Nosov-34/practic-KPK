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

        private async void KorpBTN_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.IsEnabled = false;
            }
            await Navigation.PushModalAsync(new Corps());
            MessagingCenter.Send(EventArgs.Empty, "OpenMenu");
        }

        private async void SpecBTN_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProfPage());
            MessagingCenter.Send(EventArgs.Empty, "OpenMenu");
        }

        private async void StudentBTN_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StudentPage());
            MessagingCenter.Send(EventArgs.Empty, "OpenMenu");
        }
        private void VKBTN_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://vk.com/koppk174"));
        }

        private void InternetBTN_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://kpk74.ru/ru"));
        }

        private void News1BTN_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://kpk74.ru/ru/press-center/events/intellektualno-razvlekatelnyy-kviz-svoya-igra/%22"));
        }

        private void News2BTN_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://kpk74.ru/ru/press-center/events/konkursy/slet-studencheskogo-aktiva-kolledzha-na-baze-otdykha-belousovo/%22"));
        }

        private void News3BTN_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://kpk74.ru/ru/press-center/events/konkursy/vsemirnyy-den-bez-tabaka/%22"));
        }

        private void News4BTN_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://kpk74.ru/ru/press-center/events/konkursy/vybory-molodezh-budushchee-/%22"));
        }
    }
}
