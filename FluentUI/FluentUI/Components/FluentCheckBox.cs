using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FluentUI.Components
{
    public class FluentCheckBox : Xamarin.Forms.CheckBox
    {

        FluentColor colors = new FluentColor();
        public FluentCheckBox()
        {


            var vsg = new VisualStateGroup();
            var vs = new VisualState();

            if(vs.Name == "Checked")
            {
                Color = colors.NeutralTertiaryAlt;
            }
            else if (vs.Name == "Normal")
            {
                Color = colors.ThemePrimary;
            }

            vsg.States.Add(vs);

        }
    }
}
