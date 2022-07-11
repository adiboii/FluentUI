using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;
using Xamarin.Essentials;
using FluentUI.Components;
using FluentUI.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(FluentRadioButton), typeof(RadioButtonAndroid))]
namespace FluentUI.Droid
{
    public class RadioButtonAndroid : RadioButtonRenderer
    {
        public RadioButtonAndroid(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.RadioButton> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.ButtonTintList = ColorStateList.ValueOf(Android.Graphics.Color.Yellow);
            }
        }




    }
}
