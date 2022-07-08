using System;
using System.Collections.Generic;
using System.Text;

namespace FluentUI.Components
{
    public class FluentToggle : Xamarin.Forms.Switch
    {

        FluentColor colors = new FluentColor();
        public FluentToggle()
        {
            if(IsToggled == true)
            {
                OnColor = colors.ThemeTertiary;
                ThumbColor = colors.ThemePrimary;
            }
            else
            {
                ThumbColor = colors.NeutralLight;
            }
        }
    }
}
