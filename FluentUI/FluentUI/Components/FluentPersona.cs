using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    public class FluentPersona : Xamarin.Forms.Frame
    {
        // Legend:
        //  Course of Action (COA)
        //
        // To-Do List | FluentPersona
        // 1. Name Attribute
        //    1.A. Situation: "Name" has already been initialized
        //         COA: Erase "Name" attribute
        //         Problem: Initials are still displayed
        //    2.A. 

        // Local Declarations
        FluentColor colors = new FluentColor();
        Label initials = new Label();
        Image picture = new Image();

        // Constructor
        public FluentPersona()
        {
            this.CornerRadius = 100;
            this.HeightRequest = 32;
            this.WidthRequest = 32;
            this.HorizontalOptions = Xamarin.Forms.LayoutOptions.Center;
            this.Padding = 0;
            this.IsClippedToBounds = true;
            this.BackgroundColor = colors.ThemePrimary;
            initials.TextColor = colors.White;
            initials.Text = string.Empty;
        }

        // Bindable Properties
        public static readonly BindableProperty frameSize = BindableProperty.Create(
            "FrameSize", typeof(string), typeof(FluentPersona), "M");

        public static readonly BindableProperty name = BindableProperty.Create(
            "Name", typeof(string), typeof(FluentPersona), "");

        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(FluentPersona), false);

        public static readonly BindableProperty source = BindableProperty.Create(
            "Source", typeof(string), typeof(FluentPersona), "");

        // Getters and Setters
        public string FrameSize
        {
            get { return (string)GetValue(FluentPersona.frameSize); }
            set
            {
                SetValue(FluentPersona.frameSize, value);
                switch (value)
                {
                    case "XS":
                        this.HeightRequest = 20;
                        this.WidthRequest = 20;
                        break;
                    case "S":
                        this.HeightRequest = 24;
                        this.WidthRequest = 24;
                        break;
                    case "M":
                        this.HeightRequest = 32;
                        this.WidthRequest = 32;
                        break;
                    case "L":
                        this.HeightRequest = 40;
                        this.WidthRequest = 40;
                        break;
                    case "XL":
                        this.HeightRequest = 52;
                        this.WidthRequest = 52;
                        break;
                    case "XXL":
                        this.HeightRequest = 64;
                        this.WidthRequest = 64;
                        break;
                    default:
                        this.HeightRequest = 32;
                        this.WidthRequest = 32;
                        break;
                }
            }
        }
        public string Name
        {
            get { return (string)GetValue(FluentPersona.name); }
            set
            {
                SetValue(FluentPersona.name, value);
                if (value == string.Empty)
                    initials.Text = string.Empty;
                else
                {
                    string firstName = string.Empty;
                    string lastName = string.Empty;

                    string[] words = value.Split(' ');

                    if (IsRomanNumeral(words[words.Length - 1]) ||
                        words[words.Length - 1].Equals("Jr.") ||
                        words[words.Length - 1].Equals("Sr.")
                        )
                        Array.Resize(ref words, words.Length - 1);

                    if (words[0].Contains(","))
                    {
                        lastName = words[0].Substring(0, words[0].Length - 2);
                        firstName = words[1];
                    }
                    else
                    {
                        firstName = words[0].ToString();
                        lastName = words[words.Length - 1];
                    }

                    string inits = firstName[0].ToString() + lastName[0].ToString();

                    initials.Text = inits;
                    initials.TextTransform = TextTransform.Uppercase;
                    initials.HorizontalOptions = LayoutOptions.Center;
                    initials.VerticalOptions = LayoutOptions.Center;
                }
                this.Content = initials;
            }
        }
        public bool DarkMode
        {
            get { return (bool)GetValue(FluentPersona.darkMode); }
            set
            {
                SetValue(FluentPersona.darkMode, value);
                if (value)
                    initials.TextColor = colors.Black;
                else if (!value)
                    initials.TextColor = colors.White;
            }
        }
        public string Source
        {
            get { return (string)GetValue(FluentPersona.source); }
            set
            {
                SetValue(FluentPersona.source, value);
                if (value != "")
                {
                    picture.Source = value;
                    this.Content = picture;
                }
            }
        }

        // Functions
        public bool IsRomanNumeral(string word)
        {
            // "previousValue" is initialized to 1001
            // since the largest value of a Roman numeral
            // character is 1000
            int previousValue = 1001;

            // "previousChar" is initialized to 'A'
            // since 'A' is not a Roman numeral character
            char previousChar = 'A';
            int nPreviousChar = 0; // Succeeding number of occurrences of the previous character

            foreach (char c in word)
            {
                // Return "false" if the character being
                // traversed is not a Roman numeral
                // character
                if (GetRomanNumeralValue(c) == 0)
                    return false;

                if (previousChar == c)
                    nPreviousChar++;

                // Roman numerals must not have four (4)
                // succeeding characters that are the same
                if (nPreviousChar == 4)
                    return false;

                if (GetRomanNumeralValue(c) > previousValue)
                {
                    // Subtractive Notation
                    switch (c)
                    {
                        case 'V':
                        case 'X':
                            if (previousChar == 'I')
                                break;
                            else
                                return false;
                        case 'L':
                        case 'C':
                            if (previousChar == 'X')
                                break;
                            else
                                return false;
                        case 'D':
                        case 'M':
                            if (previousChar == 'C')
                                break;
                            else
                                return false;
                    }
                }

                previousChar = c;
            }
            return true;
        }
        public int GetRomanNumeralValue(char c)
        {
            int value = 0;
            switch (c)
            {
                case 'I':
                    value = 1;
                    break;
                case 'V':
                    value = 5;
                    break;
                case 'X':
                    value = 10;
                    break;
                case 'L':
                    value = 50;
                    break;
                case 'C':
                    value = 100;
                    break;
                case 'D':
                    value = 500;
                    break;
                case 'M':
                    value = 1000;
                    break;
                default:
                    value = 0;
                    break;
            }
            return value;
        }
    }
}