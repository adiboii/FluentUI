using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Shapes;


namespace FluentUI.Components
{
    public class FluentButton : Xamarin.Forms.Button
    {
        // Local Declarations
        FluentColor colors = new FluentColor();

        // Constructor
        public FluentButton()
        {
            this.CornerRadius = 2;
            this.WidthRequest = 94;
            this.HeightRequest = 40;
            this.BackgroundColor = colors.ThemePrimary;
            this.TextColor = colors.White;
            this.DarkMode = false;
        }

        // Bindable Properties
        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(FluentButton), false);

        // Getters and Setters

        public bool DarkMode
        {
            get { return (bool)GetValue(FluentButton.darkMode); }
            set
            { SetValue(FluentButton.darkMode, value); }
        }
    }
}
