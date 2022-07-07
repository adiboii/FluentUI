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
    public partial class ProfilePicture : ContentView 
    {
        public ProfilePicture()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty frameWidth = BindableProperty.Create(
          "FrameWidth", typeof(int), typeof(ProfilePicture), 36);

        public int FrameWidth
        {
            get { return (int)GetValue(ProfilePicture.frameWidth); }
            set { SetValue(ProfilePicture.frameWidth, value); }
        }


        public static readonly BindableProperty frameHeight = BindableProperty.Create(
          "FrameHeight", typeof(int), typeof(ProfilePicture), 36);

        public int FrameHeight
        {
            get { return (int)GetValue(ProfilePicture.frameHeight); }
            set { SetValue(ProfilePicture.frameHeight, value); }
        }

        public static readonly BindableProperty imageSource = BindableProperty.Create(
          "ImageSource", typeof(string), typeof(ProfilePicture), "profile.png");

        public string ImageSource
        {
            get { return (string)GetValue(ProfilePicture.imageSource); }
            set { SetValue(ProfilePicture.imageSource, value); }
        }
    }
}