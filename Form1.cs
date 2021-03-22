using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorPiker
{
    public partial class Form1 : Form
    {
        public string R, G, B;

        private void copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(clr_code.Text);
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void cntClk_Tick(object sender, EventArgs e)
        {
            clr_view.BackColor = Color.FromArgb(red_scale.Value, green_scale.Value, blue_scale.Value);
            R = red_scale.Value.ToString();
            G = green_scale.Value.ToString();
            B = blue_scale.Value.ToString();
            clr_code.Text = "RGB(" + R + "," + G + "," + B + ")";
        }
    }
}
