using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace FluentUI.Components
{
    public class FluentTextBox : Xamarin.Forms.Frame
    {
        FluentColor colors = new FluentColor();

        public static readonly BindableProperty placeHolder = BindableProperty.Create(
           "PlaceHolder", typeof(string), typeof(FluentTextBox), "Search");
        public string PlaceHolder 
        { 
            get { return (string)GetValue(FluentTextBox.placeHolder); }
            set { SetValue(FluentTextBox.placeHolder, value); } 
        }

        public static readonly BindableProperty hasIcon = BindableProperty.Create(
            "HasIcon", typeof(bool), typeof(FluentTextBox), false);

        public bool HasIcon 
        { 
            get { return (bool)GetValue(FluentTextBox.hasIcon); } 
            set { SetValue(FluentTextBox.hasIcon, value); }
        }

        public static readonly BindableProperty textColor = BindableProperty.Create(
         "TextColor", typeof(Color), typeof(FluentTextBox), Color.Black);

        public Color TextColor
        {
            get { return (Color)GetValue(FluentTextBox.textColor); }    
            set { SetValue(FluentTextBox.textColor, value); }
        }

        public static readonly BindableProperty placeholderColor = BindableProperty.Create(
        "PlaceholderColor", typeof(Color), typeof(FluentTextBox), Color.Black);

        public Color PlaceholderColor
        {
            get { return (Color)GetValue(FluentTextBox.textColor); }
            set { SetValue(FluentTextBox.textColor, value); }
        }

        public FluentTextBox()
        {
            BackgroundColor = colors.NeutralLight;
            Padding = new Thickness(10, 0);
            Margin = new Thickness(0);

            StackLayout stack = new StackLayout();
            stack.Spacing = 5;
            stack.Orientation = StackOrientation.Horizontal;

            TextBox textbox = new TextBox()
            {
                Placeholder = PlaceHolder,
                PlaceholderColor = PlaceholderColor,
                FontSize = 14,
                TextColor = TextColor,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
            };

            //image to add later
            Label l = new Label();  
            l.Text = "A";
            l.VerticalOptions = LayoutOptions.Center;
            l.HorizontalOptions = LayoutOptions.Center;
            stack.Children.Add(l);
            stack.Children.Add(textbox);
            Content = stack;
        }
    }
}
