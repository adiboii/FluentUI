using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FluentUI.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Initials : ContentView
    {
        public Initials()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty frameWidth = BindableProperty.Create(
           "FrameWidth", typeof(int), typeof(Initials), 36);

        public int FrameWidth
        {
            get { return (int)GetValue(Initials.frameWidth); }
            set { SetValue(Initials.frameWidth, value); }
        }


        public static readonly BindableProperty frameHeight = BindableProperty.Create(
          "FrameHeight", typeof(int), typeof(Initials), 36);

        public int FrameHeight
        {
            get { return (int)GetValue(Initials.frameHeight); }
            set { SetValue(Initials.frameHeight, value); }
        }

        public static readonly BindableProperty userInitials = BindableProperty.Create(
         "UserInitials", typeof(string), typeof(Initials), "AA");

        public string UserInitials
        {
            get { return (string)GetValue(Initials.userInitials); }
            set { SetValue(Initials.userInitials, value); }
        }

    }
}