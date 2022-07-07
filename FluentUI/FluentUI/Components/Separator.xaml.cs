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
    public partial class Separator : ContentView
    {
        public Separator()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty SeparatorWidth = BindableProperty.Create(
            "CustomWidth", typeof(int),typeof(Separator), 250);

        public int CustomWidth
        {
            get { return (int)GetValue(Separator.SeparatorWidth); }
            set { SetValue(Separator.SeparatorWidth, value); }
        }

    }
}