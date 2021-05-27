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
        public float C, X, M, R, G, B, H, S, V, H1, S1, V1;
        public int R1, G1, B1;
        public Boolean ClrScheeme1, tone_sec_active;



        public Form1()
        {
            InitializeComponent();
            ClrScheeme1 = true;
            tone_sec.Hide();
            tone_sec_active = false;
            alpha.Value = 255;

        }

        private void tone_togle_Click(object sender, EventArgs e)
        {
            if(!tone_sec_active)
                tone_sec.Show();
            else
                tone_sec.Hide();

            tone_sec_active = !tone_sec_active;
        }

        public float Max(float n1, float n2, float n3)
        {
            if (n1 > n2 && n1> n3)
                return n1;

            if (n2 > n1 && n2 > n3)
                return n2;

            if (n3 > n2 && n3 > n1)
                return n3;

            return 0;
        }

        private void tnSc1_Click(object sender, EventArgs e)
        {
            toggleHSV();

            red_scale.Maximum = 360;
            green_scale.Maximum = 100;
            blue_scale.Maximum = 100;

            red_scale.Minimum = 0;
            green_scale.Minimum = 0;
            blue_scale.Minimum = 0;

            green_scale.Value = 75;
            green_scale.Maximum = 83;
            green_scale.Minimum = 73; 
            

            blue_scale.Value = 65;
            blue_scale.Maximum = 76;
            blue_scale.Minimum = 56;
            

            tone_sec.Hide();
            tone_sec_active = false;
            ton_scale.Text = "jewel";
        }

        private void tnSc2_Click(object sender, EventArgs e)
        {
            toggleHSV();

            red_scale.Maximum = 360;
            green_scale.Maximum = 100;
            blue_scale.Maximum = 100;

            red_scale.Minimum = 0;
            green_scale.Minimum = 0;
            blue_scale.Minimum = 0;

            green_scale.Value = 5;
            green_scale.Maximum = 10;
            green_scale.Minimum = 1;
            

            blue_scale.Value = 80;
            blue_scale.Maximum = 99;
            blue_scale.Minimum = 70;
            

            tone_sec.Hide();
            tone_sec_active = false;
            ton_scale.Text = "neutral";
        }

        private void tnSc3_Click(object sender, EventArgs e)
        {
            toggleHSV();

            red_scale.Maximum = 360;
            green_scale.Maximum = 100;
            blue_scale.Maximum = 100;

            red_scale.Minimum = 0;
            green_scale.Minimum = 0;
            blue_scale.Minimum = 0;

            green_scale.Value = 41;
            green_scale.Maximum = 46;
            green_scale.Minimum = 36;


            blue_scale.Value = 50;
            blue_scale.Maximum = 77;
            blue_scale.Minimum = 36;
            

            tone_sec.Hide();
            tone_sec_active = false;
            ton_scale.Text = "earth";
        }

        private void tnSc4_Click(object sender, EventArgs e)
        {
            toggleHSV();

            red_scale.Maximum = 360;
            green_scale.Maximum = 100;
            blue_scale.Maximum = 100;

            red_scale.Minimum = 0;
            green_scale.Minimum = 0;
            blue_scale.Minimum = 0;

            green_scale.Value = 00;
            green_scale.Maximum = 00;
            green_scale.Minimum = 00;


            blue_scale.Value = 50;
            blue_scale.Maximum = 100;
            blue_scale.Minimum = 00;
            

            tone_sec.Hide();
            tone_sec_active = false;
            ton_scale.Text = "shades";
        }

        private void tnSc5_Click(object sender, EventArgs e)
        {
            toggleHSV();

            red_scale.Maximum = 360;
            green_scale.Maximum = 100;
            blue_scale.Maximum = 100;

            red_scale.Minimum = 0;
            green_scale.Minimum = 0;
            blue_scale.Minimum = 0;

            green_scale.Value = 18;
            green_scale.Maximum = 21;
            green_scale.Minimum = 14;
            
            
            blue_scale.Value = 91;
            blue_scale.Maximum = 96;
            blue_scale.Minimum = 86;
            

            tone_sec.Hide();
            tone_sec_active = false;
            ton_scale.Text = "pastel";
        }

        private void tnSc6_Click(object sender, EventArgs e)
        {

            toggleHSV();

            red_scale.Maximum = 360;
            green_scale.Maximum = 100;
            blue_scale.Maximum = 100;

            red_scale.Minimum = 0;
            green_scale.Minimum = 0;
            blue_scale.Minimum = 0;

            green_scale.Value = 75;
            green_scale.Maximum = 100;
            green_scale.Minimum = 63;
            
            
            blue_scale.Value = 92;
            blue_scale.Maximum = 100;
            blue_scale.Minimum = 82;
            

            tone_sec.Hide();
            tone_sec_active = false;
            ton_scale.Text = "fluorescent";
        }

        private void tnSc7_Click(object sender, EventArgs e)
        {
            toggleHSV();

            red_scale.Maximum = 360;
            green_scale.Maximum = 100;
            blue_scale.Maximum = 100;

            red_scale.Minimum = 0;
            green_scale.Minimum = 0;
            blue_scale.Minimum = 0;

            green_scale.Value = 75;
            green_scale.Maximum = 100;
            green_scale.Minimum = 63;

            tone_sec.Hide();
            tone_sec_active = false;
            ton_scale.Text = "none";
        }

        public float Min(float n1, float n2, float n3)
        {
            if (n1 < n2 && n1 < n3)
                return n1;

            if (n2 < n1 && n2 < n3)
                return n2;

            if (n3 < n2 && n3 < n1)
                return n3;

            return 0;
        }

        public void cRtoH()
        {

            H1 = H / 255;
            S1 = S / 255;
            V1 = V / 255;
            C = Max(H1,S1,V1);
            X = Min(H1, S1, V1);
            M = C - X;


            if (M==0)
                R = 0;
            else if (C == H1)
                R = (((S1 - V1) / M) % 6);
            else if (C == S1)
                R = (((V1 - H1) / M) + 2);
            else if (C == V1)
                R = (((H1 - S1) / M) + 4);


            R *= 60;

            if (C == 0)
                G = 0;
            else
                G = (M / C) * 100;

            if((S1 - V1)== 0)
                G = S1 *100;


            if (M == 0 && S1 != 1.0)
                B = V1 * 100;
            else
                B = C*100;

            R1 = (int)Math.Round(R);
            G1 = (int)Math.Round(G);
            B1 = (int)Math.Round(B);

        }

        public void cHtoR()
        {

            C = (V / 100) * (S / 100);
            X = C * (1 - Math.Abs((((H / 60) % 2) - 1)));
            M = (V / 100) - C;


            if (0 <= H && H < 60)
            {
                R = C;
                G = X;
                B = 0;
            }
            else if (60 <= H && H < 120)
            {
                R = X;
                G = C;
                B = 0;
            }
            else if (120 <= H && H < 180)
            {
                R = 0;
                G = C;
                B = X;
            }
            else if (180 <= H && H < 240)
            {
                R = 0;
                G = X;
                B = C;
            }
            else if (240 <= H && H < 300)
            {
                R = X;
                G = 0;
                B = C;
            }
            else if (300 <= H && H <= 360)
            {
                R = C;
                G = 0;
                B = X;
            }
        }


        public void toggleHSV()
        {
            if (!ClrScheeme1)
            {
                toHSV.ForeColor = Color.FromArgb(20, 20, 20);
                toHSV.BackColor = Color.FromArgb(200, 200, 200, 15);
                toRGB.BackColor = Color.FromArgb(80, 80, 80, 100);
                toRGB.ForeColor = Color.FromArgb(80, 80, 80);


                cRtoH();
                ClrScheeme1 = true;


                label1.Text = "H";
                label2.Text = "S";
                label3.Text = "V";

                red_scale.Maximum = 360;
                green_scale.Maximum = 100;
                blue_scale.Maximum = 100;

                red_scale.Minimum = 0;
                green_scale.Minimum = 0;
                blue_scale.Minimum = 0;


                red_scale.Value = Math.Abs(R1);
                green_scale.Value =Math.Abs(G1);
                blue_scale.Value = Math.Abs(B1);
            }
        }

        public void toggleRGB()
        {
            if (ClrScheeme1)
            {
                toRGB.ForeColor = Color.FromArgb(20, 20, 20);
                toHSV.BackColor = Color.FromArgb(80, 80, 80, 100);
                toRGB.BackColor = Color.FromArgb(200, 200, 200, 15);
                toHSV.ForeColor = Color.FromArgb(80, 80, 80);


                cHtoR();
                ClrScheeme1 = false;


                label1.Text = "R";
                label2.Text = "G";
                label3.Text = "B";

                red_scale.Maximum = 255;
                green_scale.Maximum = 255;
                blue_scale.Maximum = 255;

                red_scale.Minimum = 0;
                green_scale.Minimum = 0;
                blue_scale.Minimum = 0;

                red_scale.Value = Math.Abs(R1);
                green_scale.Value = Math.Abs(G1);
                blue_scale.Value = Math.Abs(B1);
            }
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(clr_code.Text);
        }


        private void toHSV_Click(object sender, EventArgs e)
        {
            toggleHSV();
        }

        private void toRGB_Click(object sender, EventArgs e)
        {
            toggleRGB();
        }



        private void rec1_TextChanged(object sender, EventArgs e)
        {
            if (rec1.Text != "")
                red_scale.Value = Int32.Parse(rec1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (rec3.Text != "")
                blue_scale.Value = Int32.Parse(rec3.Text);
        }

        private void rec2_TextChanged(object sender, EventArgs e)
        {
            if (rec2.Text != "")
                green_scale.Value = Int32.Parse(rec2.Text);
        }

        public void RGBise()
        {
            R1 = red_scale.Value;
            G1 = green_scale.Value;
            B1 = blue_scale.Value;
        }


        public void HSVise()
        {
            cHtoR();

            R1 = (int)Math.Round((R + M) * 255);
            G1 = (int)Math.Round((G + M) * 255);
            B1 = (int)Math.Round((B + M) * 255);

        }


        

        private void cntClk_Tick(object sender, EventArgs e)
        {
            H = red_scale.Value;
            S = green_scale.Value;
            V = blue_scale.Value;

            rec3.Text = V.ToString();
            rec1.Text = H.ToString();
            rec2.Text = S.ToString();

            if (ClrScheeme1)
                HSVise();
            else
                RGBise();

            clr_view.BackColor = Color.FromArgb(alpha.Value,R1, G1, B1);
            clr_code.Text = "#" + R1.ToString("X2") + G1.ToString("X2") + B1.ToString("X2") + alpha.Value.ToString("X2");
        }
    }
}
