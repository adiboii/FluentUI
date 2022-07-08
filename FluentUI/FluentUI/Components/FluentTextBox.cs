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

        public FluentTextBox()
        {
            BackgroundColor = colors.NeutralLight;
            Padding = new Thickness(10, 0);
            Margin = new Thickness(0);

            Grid grid = new Grid();
            StackLayout stack = new StackLayout();
            stack.Spacing = 5;
            stack.Orientation = StackOrientation.Horizontal;

            Content = stack;
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            TextBox textbox = new TextBox()
            {
                Placeholder = PlaceHolder,
                FontSize = 14,
                TextColor = colors.NeutralDark,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
            };

            //image to add later
            Label l = new Label();
            l.Text = "O";
            l.VerticalOptions = LayoutOptions.Center;
            l.HorizontalOptions = LayoutOptions.Center;
            stack.Children.Add(l);
            stack.Children.Add(textbox);
        }




    }
}
