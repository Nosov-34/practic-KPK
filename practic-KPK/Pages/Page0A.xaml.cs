﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace practic_KPK.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page0A : ContentPage
{
    public Page0A()
    {
        InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void button1_Clicked(object sender, EventArgs e)
        {
            DisabledButtons.UnLockButtons();
            await Navigation.PopModalAsync();
        }
    }
}