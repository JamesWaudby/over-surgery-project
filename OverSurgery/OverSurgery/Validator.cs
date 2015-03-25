using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OverSurgery;

namespace OverSurgeryForms
{
    public static class Validator
    {
        // Loop through textboxes and validate their fields
        public static bool ValidateTextFields(TextBox[] textBoxes)
        {
            bool valid = true;

            foreach (TextBox t in textBoxes)
            {
                if (t.Text == string.Empty)
                {
                    t.BackColor = Color.LightCoral;
                    valid = false;
                }
            }
            
            return valid;
        }

    }
}
