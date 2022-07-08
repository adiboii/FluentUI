using FluentUI.Components;
using FluentUI.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(TextBox), typeof(TextBoxIOS))]
namespace FluentUI.iOS
{
    public class TextBoxIOS : EntryRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

           if(e.OldElement == null)
            {
                Control.Layer.BorderColor = Color.Transparent.ToCGColor();
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }

    }
}