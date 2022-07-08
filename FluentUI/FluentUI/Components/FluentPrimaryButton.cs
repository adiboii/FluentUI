using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    public class FluentPrimaryButton : FluentButton
    {
        // Local Declartions
        FluentColor colors = new FluentColor();

        // Constructors
        public FluentPrimaryButton()
        {
            this.BackgroundColor = colors.ThemePrimary;
        }

        // Bindable Properties
        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(FluentPrimaryButton), false);

        // Getters and Setters
        public bool DarkMode
        {
            get { return (bool)GetValue(FluentPrimaryButton.darkMode); }
            set
            { 
              SetValue(FluentPrimaryButton.darkMode, value);
              if (this.DarkMode == true)
                this.TextColor = colors.Black;
              else
                this.TextColor = colors.White;
            }
        }
    }
}
