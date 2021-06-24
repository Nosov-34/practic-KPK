using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: ExportFont("/montserrat/regular.ttf", Alias = "MontserratRegular")]
[assembly: ExportFont("/montserrat/semibold.ttf", Alias = "MontserratSemiBold")]
[assembly: ExportFont("/montserrat/black.ttf", Alias = "MontserratBlack")]
[assembly: ExportFont("/montserrat/blackitalic.ttf", Alias = "MontserratBlackItalic")]
[assembly: ExportFont("/montserrat/bold.ttf", Alias = "MontserratBold")]
[assembly: ExportFont("/montserrat/bolditalic.ttf", Alias = "MontserratBoldItalic")]
[assembly: ExportFont("/montserrat/extrabold.ttf", Alias = "MontserratExtraBold")]
[assembly: ExportFont("/montserrat/extrabolditalic.ttf", Alias = "MontserratExtraBoldItalic")]
[assembly: ExportFont("/montserrat/extralight.ttf", Alias = "MontserratExtraLight")]
[assembly: ExportFont("/montserrat/extralightitalic.ttf", Alias = "MontserratExtraLightItalic")]
[assembly: ExportFont("/montserrat/italic.ttf", Alias = "MontserratItalic")]
[assembly: ExportFont("/montserrat/light.ttf", Alias = "MontserratLight")]
[assembly: ExportFont("/montserrat/lightitalic.ttf", Alias = "MontserratLightItalic")]
[assembly: ExportFont("/montserrat/medium.ttf", Alias = "MontserratMedium")]
[assembly: ExportFont("/montserrat/mediumitalic.ttf", Alias = "MontserratMediumItalic")]
[assembly: ExportFont("/montserrat/semibolditalic.ttf", Alias = "MontserratSemiBoldItalic")]
[assembly: ExportFont("/montserrat/thin.ttf", Alias = "MontserratThin")]
[assembly: ExportFont("/montserrat/thinitalic.ttf", Alias = "MontserratThinItalic")]

namespace practic_KPK
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
