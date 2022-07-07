using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FluentUI.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Button : ContentView
    {
        public Button()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty text = BindableProperty.Create(
      "Text", typeof(string), typeof(Button), "DEFAULT");

        public string Text
        {
            get { return (string)GetValue(Button.text); }
            set { SetValue(Button.text, value); }
        }
    }
}