using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    public class FluentTextButton : FluentButton
    {
        // Local Declartions
        FluentColor colors = new FluentColor();

        // Constructors
        public FluentTextButton()
        {
            this.TextColor = colors.ThemePrimary;
            this.BackgroundColor = colors.White;
        }

        // Bindable Properties
        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(FluentTextButton), false);

        // Getters and Setters
        public bool DarkMode
        {
            get { return (bool)GetValue(FluentTextButton.darkMode); }
            set
            {
                SetValue(FluentTextButton.darkMode, value);
                if (this.DarkMode == true)
                    this.BackgroundColor = colors.Black;
                else
                    this.BackgroundColor = colors.White;
            }
        }
    }
}
