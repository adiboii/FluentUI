using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    internal class FluentAppBar : Xamarin.Forms.Frame
    {
        // Local Declarations
        FluentColor colors = new FluentColor();
        StackLayout appBar = new StackLayout();

        StackLayout titles = new StackLayout();
        Label title;
        Label subtitle = new Label();

        // Constructor
        public FluentAppBar()
        {
            this.HorizontalOptions = Xamarin.Forms.LayoutOptions.FillAndExpand;
            this.HeightRequest = 36;
            this.BackgroundColor = colors.ThemePrimary;
            this.Content = appBar;

      

            title = new Label()
            {
                Text = "Title",
                TextColor = colors.White,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
            };

            subtitle = new Label()
            {
                Text = "Subtitle",
                TextColor = colors.White,
                FontSize = 12,
            };

            titles.Children.Add(title);
            titles.Children.Add(subtitle);
            titles.VerticalOptions = LayoutOptions.Fill;
            titles.HorizontalOptions = LayoutOptions.Center;

            appBar.Orientation = StackOrientation.Horizontal;
            appBar.Spacing = 16;
            appBar.BackgroundColor = colors.ThemePrimary;
            appBar.HorizontalOptions = LayoutOptions.FillAndExpand;
            appBar.VerticalOptions = LayoutOptions.Center;
            
            appBar.Children.Add(titles);
        }

        // BindableProperties
        public static readonly BindableProperty name = BindableProperty.Create(
           "Name", typeof(string), typeof(FluentAppBar), "");
    }
}
