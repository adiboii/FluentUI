using System;
using System.Collections.Generic;
using System.Text;

namespace FluentUI.Components
{
    public class FluentRadioButton : Xamarin.Forms.RadioButton
    {

        FluentColor colors = new FluentColor();
        FluentRadioButton()
        {
            BorderColor = colors.ThemePrimary;
            
        }
    }
}
