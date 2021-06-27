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

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page1B());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page0A());
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page2C());
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page3D());
        }

        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page4E());
        }

        private async void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page5F());
        }

        private async void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page6G());
        }

        private async void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page7H());
        }

        private async void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                 DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page8I());
        }

        private async void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page9J());
        }

        private async void TapGestureRecognizer_Tapped_10(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page10K());
        }

        private async void TapGestureRecognizer_Tapped_11(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                 DisabledButtons.DisableButton(button);
            }
            await Navigation.PushModalAsync(new Page11L());
        }

        private async void Back(object sender, EventArgs e)
        {
            DisabledButtons.UnLockButtons();
            await Navigation.PopModalAsync();
        }
    }
}
