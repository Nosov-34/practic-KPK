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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page1());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page2());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page3());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page4());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                 DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page5());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page6());
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            DisabledButtons.UnLockButtons();
            await Navigation.PopModalAsync();
        }
    }
}