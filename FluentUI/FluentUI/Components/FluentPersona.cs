using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    public class FluentPersona : Xamarin.Forms.Frame
    {
        // Constructor
        public FluentPersona()
        {
            this.CornerRadius = 100;
            this.HeightRequest = 32;
            this.WidthRequest = 32;
            this.HorizontalOptions = Xamarin.Forms.LayoutOptions.Center;
            this.Padding = 0;
            this.IsClippedToBounds = true;
        }

        // Bindable Properties
        public static readonly BindableProperty frameSize = BindableProperty.Create(
            "FrameSize", typeof(string), typeof(FluentProfilePicture), "M");

        // Getters and Setters
        public string FrameSize
        {
            get { return (string)GetValue(FluentProfilePicture.frameSize); }
            set
            {
                SetValue(FluentProfilePicture.frameSize, value);
                switch (value)
                {
                    case "XS":
                        this.HeightRequest = 20;
                        this.WidthRequest = 20;
                        break;
                    case "S":
                        this.HeightRequest = 24;
                        this.WidthRequest = 24;
                        break;
                    case "M":
                        this.HeightRequest = 32;
                        this.WidthRequest = 32;
                        break;
                    case "L":
                        this.HeightRequest = 40;
                        this.WidthRequest = 40;
                        break;
                    case "XL":
                        this.HeightRequest = 52;
                        this.WidthRequest = 52;
                        break;
                    case "XXL":
                        this.HeightRequest = 64;
                        this.WidthRequest = 64;
                        break;
                    default:
                        this.HeightRequest = 32;
                        this.WidthRequest = 32;
                        break;
                }
            }
        }
    }
}
