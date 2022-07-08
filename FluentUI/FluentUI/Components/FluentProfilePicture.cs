using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    public class FluentProfilePicture : FluentPersona
    {
        // Local Declarations
        Image picture = new Image();

        // Constructor
        public FluentProfilePicture(){}

        // Bindable Properties

        public static readonly BindableProperty source = BindableProperty.Create(
            "Source", typeof(string), typeof(FluentProfilePicture), "");

        public string Source
        {
            get { return (string)GetValue(FluentProfilePicture.source); }
            set { 
                SetValue(FluentProfilePicture.source, value);
                picture.Source = value;
                this.Content = picture;
            }
        }
    }
}
