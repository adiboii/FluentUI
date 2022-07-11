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

        private void Controls_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlsPage());
        }

        private void Entry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryForms());
        }

        private void AppBar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppBarPage());
        }

        private void Chips_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChipsPage());
        }

        private void Persona_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Persona());
        }
    }
}
