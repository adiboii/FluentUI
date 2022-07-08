using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    internal class FluentImageButton : Xamarin.Forms.Frame
    {
        // Constructor
        int Width;
        int Height;
        public FluentImageButton()
        {
            this.Width = 22;
            this.Height = 22;

        }
        // Bindable Properties
        public static readonly BindableProperty sizeType = BindableProperty.Create(
            "SizeType", typeof(char), typeof(FluentImageButton), 'R');
        // R : Regular
        // L : Large

        // Getters and Setters
        public char SizeType
        {
            get { return (char)GetValue(FluentImageButton.sizeType); }
            set
            {
                SetValue(FluentImageButton.sizeType, value);
                if (value == 'R')
                {
                    this.Width = 22;
                    this.Height = 22;
                }
                else if (value == 'L')
                {
                    this.Width = 24;
                    this.Height = 24;
                }
            }
        }

    }
}

