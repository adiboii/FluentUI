using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    public class FluentInitials : FluentPersona
    {
        // Local Declarations
        FluentColor colors = new FluentColor();
        Label initials = new Label();

        // Constructors
        public FluentInitials()
        {
            this.VerticalOptions = Xamarin.Forms.LayoutOptions.Center;
            this.BackgroundColor = colors.ThemePrimary;
            initials.TextColor = colors.White;
        }

        // Bindable Properties
        public static readonly BindableProperty name = BindableProperty.Create(
            "Name", typeof(string), typeof(FluentInitials), "");

        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(FluentInitials), false);

        // Getters and Setters
        public string Name
        {
            get { return (string)GetValue(FluentInitials.name); }
            set
            {
                SetValue(FluentInitials.name, value);
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
                this.Content = initials;
            }
        }

        public bool DarkMode
        {
            get { return (bool)GetValue(FluentInitials.darkMode); }
            set
            {
                SetValue(FluentInitials.darkMode, value);
                if (value)
                    initials.TextColor = colors.Black;
            }
        }

        // Functions
        public bool IsRomanNumeral(string word)
        {
            // "previousValue" is initialized to 1001
            // since the largest value of a roman numeral
            // character is 1000
            int previousValue = 1001;

            // "previousChar" is initialized to 'A'
            // since 'A' is not a roman numeral character
            char previousChar = 'A';
            int nPreviousChar = 0; // Succeeding number of occurrences of the previous character

            foreach (char c in word)
            {
                // Return "false" if the character being
                // traversed is not a roman numeral
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
                    switch(c)
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
            switch(c)
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
