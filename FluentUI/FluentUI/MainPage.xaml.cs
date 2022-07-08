using FluentUI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FluentUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonPage());
        }

        private void Initials_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Initials());
        }

        private void Controls_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlsPage());
        }

        private void Profile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryForms());
        }
    }
}
