using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace practic_KPK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void MenuBTN_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Оно работает", "И че?", "ОK");
        }
    }
}
