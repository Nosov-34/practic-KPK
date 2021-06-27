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
    public static class DisabledButtons
    {
        public static Button disabledButton;

        public static void DisableButton(Button newButton)
        {
            newButton.IsEnabled = false;
            if (disabledButton != null)
            {
                disabledButton.IsEnabled = true;
            }
            disabledButton = newButton;
        }

        public static void UnLockButtons()
        {
            if (disabledButton != null)
            {
                disabledButton.IsEnabled = true;
            }
            return;
        }
    }
}
