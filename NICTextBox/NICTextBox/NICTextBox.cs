using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NICTextBox
{
    public partial class NICTextBox: TextBox
    {
        public NICTextBox()
        {
            BackColor = Color.LightYellow;
            ForeColor = Color.SaddleBrown;

            HasDecimal = true;
            HasNegative = false;


        }

        [Category("Behavior")]
        public bool HasDecimal { get; set; }

        [Category("Behavior")]
        public bool HasNegative { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 'X' || e.KeyChar == 'V')
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }


    }
}
