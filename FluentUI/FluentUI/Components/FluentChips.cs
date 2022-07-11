using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    public class FluentChips : Button
    {
        static FluentColor colors = new FluentColor();
        Image image = new Image();
        //Label text = new Label();

        public static readonly BindableProperty label = BindableProperty.Create(
          "Label", typeof(string), typeof(FluentChips), "Hello");

        public string Label
        {
            get { return (string)GetValue(FluentChips.label); }
            set 
            { 
                SetValue(FluentChips.label, value); 
                //text.Text = value;
            }
        }


        public static readonly BindableProperty textColor = BindableProperty.Create(
          "TextColor", typeof(Color), typeof(FluentChips), colors.NeutralDark);

        public Color TextColor
        {
            get { return (Color)GetValue(FluentChips.textColor); }
            set
            {
                SetValue(FluentChips.textColor, value);
                //text.TextColor = value;
            }
        }


        public static readonly BindableProperty source = BindableProperty.Create(
          "Source", typeof(string), typeof(FluentChips), "profile.png");

        public string Source
        {
            get { return (string)GetValue(FluentChips.source); }
            set 
            { 
                SetValue(FluentChips.source, value); 
                image.Source = value;
            }
        }

        public FluentChips()
        {
            StackLayout stack = new StackLayout();
            stack.Spacing = 5;
            stack.Orientation = StackOrientation.Horizontal;
            stack.BackgroundColor = Color.Transparent;
            stack.VerticalOptions = LayoutOptions.Center;
            stack.HorizontalOptions = LayoutOptions.Center;

            image.WidthRequest = 15;
            image.HeightRequest = 15;
            image.VerticalOptions = LayoutOptions.Center;
            image.HorizontalOptions = LayoutOptions.Center;
            //Text.HorizontalOptions = LayoutOptions.Center;
            //Text.VerticalOptions = LayoutOptions.Center;
            //Text.FontAttributes = FontAttributes.Bold;

            stack.Children.Add(image);

            this.Text = Text;
            this.HorizontalOptions = LayoutOptions.Center;
            this.VerticalOptions = LayoutOptions.Center;
            this.Padding = new Thickness(5, 5);

            this.Content = stack;
        }
    }
}
