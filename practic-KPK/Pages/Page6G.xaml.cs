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
public partial class Page6G : ContentPage
{
    public Page6G()
    {
        InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void button7_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ProfPage());
        }
    }
}