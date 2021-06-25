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
public partial class Corps_Two : ContentPage
{
    public Corps_Two()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
     }

        private void But_Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Corps());
        }
    }
}