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
public partial class Page8I : ContentPage
{
    public Page8I()
    {
        InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void button9_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ProfPage());
        }
    }
}