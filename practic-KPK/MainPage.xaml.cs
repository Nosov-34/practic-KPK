using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Pages.Corps());
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            MessagingCenter.Send(EventArgs.Empty, "OpenMenu");
        }
    }
}
