
namespace colorPiker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer cntClk;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.red_scale = new System.Windows.Forms.TrackBar();
            this.green_scale = new System.Windows.Forms.TrackBar();
            this.blue_scale = new System.Windows.Forms.TrackBar();
            this.clr_view = new System.Windows.Forms.Panel();
            this.clr_code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rec1 = new System.Windows.Forms.TextBox();
            this.rec2 = new System.Windows.Forms.TextBox();
            this.rec3 = new System.Windows.Forms.TextBox();
            this.toRGB = new System.Windows.Forms.Button();
            this.toHSV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tone_sec = new System.Windows.Forms.Panel();
            this.tnSc7 = new System.Windows.Forms.Button();
            this.tnSc1 = new System.Windows.Forms.Button();
            this.tnSc4 = new System.Windows.Forms.Button();
            this.tnSc6 = new System.Windows.Forms.Button();
            this.tnSc5 = new System.Windows.Forms.Button();
            this.tnSc3 = new System.Windows.Forms.Button();
            this.tnSc2 = new System.Windows.Forms.Button();
            this.tone_togle = new System.Windows.Forms.Button();
            this.alpha = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copy_btn = new System.Windows.Forms.Button();
            this.ton_scale = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            cntClk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.red_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_scale)).BeginInit();
            this.panel1.SuspendLayout();
            this.tone_sec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cntClk
            // 
            cntClk.Enabled = true;
            cntClk.Interval = 10;
            cntClk.Tick += new System.EventHandler(this.cntClk_Tick);
            // 
            // red_scale
            // 
            this.red_scale.AutoSize = false;
            this.red_scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.red_scale.Location = new System.Drawing.Point(18, 9);
            this.red_scale.Margin = new System.Windows.Forms.Padding(0);
            this.red_scale.Maximum = 360;
            this.red_scale.Name = "red_scale";
            this.red_scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.red_scale.Size = new System.Drawing.Size(19, 212);
            this.red_scale.SmallChange = 0;
            this.red_scale.TabIndex = 0;
            this.red_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // green_scale
            // 
            this.green_scale.AutoSize = false;
            this.green_scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.green_scale.Location = new System.Drawing.Point(63, 9);
            this.green_scale.Margin = new System.Windows.Forms.Padding(0);
            this.green_scale.Maximum = 100;
            this.green_scale.Name = "green_scale";
            this.green_scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.green_scale.Size = new System.Drawing.Size(19, 212);
            this.green_scale.SmallChange = 0;
            this.green_scale.TabIndex = 0;
            this.green_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // blue_scale
            // 
            this.blue_scale.AutoSize = false;
            this.blue_scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.blue_scale.Location = new System.Drawing.Point(108, 9);
            this.blue_scale.Margin = new System.Windows.Forms.Padding(0);
            this.blue_scale.Maximum = 100;
            this.blue_scale.Name = "blue_scale";
            this.blue_scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blue_scale.Size = new System.Drawing.Size(19, 212);
            this.blue_scale.SmallChange = 0;
            this.blue_scale.TabIndex = 0;
            this.blue_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // clr_view
            // 
            this.clr_view.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clr_view.Location = new System.Drawing.Point(213, 12);
            this.clr_view.Name = "clr_view";
            this.clr_view.Size = new System.Drawing.Size(140, 140);
            this.clr_view.TabIndex = 1;
            // 
            // clr_code
            // 
            this.clr_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clr_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_code.ForeColor = System.Drawing.Color.White;
            this.clr_code.Location = new System.Drawing.Point(180, 167);
            this.clr_code.Name = "clr_code";
            this.clr_code.Size = new System.Drawing.Size(136, 23);
            this.clr_code.TabIndex = 2;
            this.clr_code.Text = "#00000000";
            this.clr_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(58, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(103, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "V";
            // 
            // rec1
            // 
            this.rec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec1.Location = new System.Drawing.Point(9, 282);
            this.rec1.Name = "rec1";
            this.rec1.Size = new System.Drawing.Size(37, 29);
            this.rec1.TabIndex = 5;
            this.rec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rec1.TextChanged += new System.EventHandler(this.rec1_TextChanged);
            // 
            // rec2
            // 
            this.rec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec2.Location = new System.Drawing.Point(54, 282);
            this.rec2.Name = "rec2";
            this.rec2.Size = new System.Drawing.Size(37, 29);
            this.rec2.TabIndex = 5;
            this.rec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rec2.TextChanged += new System.EventHandler(this.rec2_TextChanged);
            // 
            // rec3
            // 
            this.rec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec3.Location = new System.Drawing.Point(99, 282);
            this.rec3.Name = "rec3";
            this.rec3.Size = new System.Drawing.Size(37, 29);
            this.rec3.TabIndex = 5;
            this.rec3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rec3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // toRGB
            // 
            this.toRGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.toRGB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toRGB.FlatAppearance.BorderSize = 0;
            this.toRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toRGB.Location = new System.Drawing.Point(233, 236);
            this.toRGB.Name = "toRGB";
            this.toRGB.Size = new System.Drawing.Size(49, 31);
            this.toRGB.TabIndex = 6;
            this.toRGB.Text = "RGB";
            this.toRGB.UseVisualStyleBackColor = false;
            this.toRGB.Click += new System.EventHandler(this.toRGB_Click);
            // 
            // toHSV
            // 
            this.toHSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(15)))));
            this.toHSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toHSV.FlatAppearance.BorderSize = 0;
            this.toHSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toHSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.toHSV.Location = new System.Drawing.Point(288, 236);
            this.toHSV.Name = "toHSV";
            this.toHSV.Size = new System.Drawing.Size(49, 31);
            this.toHSV.TabIndex = 6;
            this.toHSV.Text = "HSV";
            this.toHSV.UseVisualStyleBackColor = false;
            this.toHSV.Click += new System.EventHandler(this.toHSV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ton_scale);
            this.panel1.Controls.Add(this.tone_sec);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tone_togle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(359, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 315);
            this.panel1.TabIndex = 7;
            // 
            // tone_sec
            // 
            this.tone_sec.BackColor = System.Drawing.Color.Transparent;
            this.tone_sec.Controls.Add(this.tnSc7);
            this.tone_sec.Controls.Add(this.tnSc1);
            this.tone_sec.Controls.Add(this.tnSc4);
            this.tone_sec.Controls.Add(this.tnSc6);
            this.tone_sec.Controls.Add(this.tnSc5);
            this.tone_sec.Controls.Add(this.tnSc3);
            this.tone_sec.Controls.Add(this.tnSc2);
            this.tone_sec.Dock = System.Windows.Forms.DockStyle.Top;
            this.tone_sec.Location = new System.Drawing.Point(0, 23);
            this.tone_sec.Name = "tone_sec";
            this.tone_sec.Size = new System.Drawing.Size(106, 244);
            this.tone_sec.TabIndex = 1;
            // 
            // tnSc7
            // 
            this.tnSc7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tnSc7.FlatAppearance.BorderSize = 0;
            this.tnSc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnSc7.Font = new System.Drawing.Font("Myriad Pro Cond", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tnSc7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tnSc7.Location = new System.Drawing.Point(8, 210);
            this.tnSc7.Name = "tnSc7";
            this.tnSc7.Size = new System.Drawing.Size(86, 23);
            this.tnSc7.TabIndex = 1;
            this.tnSc7.Text = "none";
            this.tnSc7.UseVisualStyleBackColor = false;
            this.tnSc7.Click += new System.EventHandler(this.tnSc7_Click);
            // 
            // tnSc1
            // 
            this.tnSc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tnSc1.FlatAppearance.BorderSize = 0;
            this.tnSc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnSc1.Font = new System.Drawing.Font("Myriad Pro Cond", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnSc1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tnSc1.Location = new System.Drawing.Point(8, 6);
            this.tnSc1.Name = "tnSc1";
            this.tnSc1.Size = new System.Drawing.Size(86, 23);
            this.tnSc1.TabIndex = 0;
            this.tnSc1.Text = "jewel";
            this.tnSc1.UseVisualStyleBackColor = false;
            this.tnSc1.Click += new System.EventHandler(this.tnSc1_Click);
            // 
            // tnSc4
            // 
            this.tnSc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tnSc4.FlatAppearance.BorderSize = 0;
            this.tnSc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnSc4.Font = new System.Drawing.Font("Myriad Pro Cond", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnSc4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tnSc4.Location = new System.Drawing.Point(8, 108);
            this.tnSc4.Name = "tnSc4";
            this.tnSc4.Size = new System.Drawing.Size(86, 23);
            this.tnSc4.TabIndex = 0;
            this.tnSc4.Text = "shades";
            this.tnSc4.UseVisualStyleBackColor = false;
            this.tnSc4.Click += new System.EventHandler(this.tnSc4_Click);
            // 
            // tnSc6
            // 
            this.tnSc6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tnSc6.FlatAppearance.BorderSize = 0;
            this.tnSc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnSc6.Font = new System.Drawing.Font("Myriad Pro Cond", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnSc6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tnSc6.Location = new System.Drawing.Point(8, 176);
            this.tnSc6.Name = "tnSc6";
            this.tnSc6.Size = new System.Drawing.Size(86, 23);
            this.tnSc6.TabIndex = 0;
            this.tnSc6.Text = "fluoresecent";
            this.tnSc6.UseVisualStyleBackColor = false;
            this.tnSc6.Click += new System.EventHandler(this.tnSc6_Click);
            // 
            // tnSc5
            // 
            this.tnSc5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tnSc5.FlatAppearance.BorderSize = 0;
            this.tnSc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnSc5.Font = new System.Drawing.Font("Myriad Pro Cond", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnSc5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tnSc5.Location = new System.Drawing.Point(8, 142);
            this.tnSc5.Name = "tnSc5";
            this.tnSc5.Size = new System.Drawing.Size(86, 23);
            this.tnSc5.TabIndex = 0;
            this.tnSc5.Text = "Pastel";
            this.tnSc5.UseVisualStyleBackColor = false;
            this.tnSc5.Click += new System.EventHandler(this.tnSc5_Click);
            // 
            // tnSc3
            // 
            this.tnSc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tnSc3.FlatAppearance.BorderSize = 0;
            this.tnSc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnSc3.Font = new System.Drawing.Font("Myriad Pro Cond", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnSc3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tnSc3.Location = new System.Drawing.Point(8, 74);
            this.tnSc3.Name = "tnSc3";
            this.tnSc3.Size = new System.Drawing.Size(86, 23);
            this.tnSc3.TabIndex = 0;
            this.tnSc3.Text = "earth";
            this.tnSc3.UseVisualStyleBackColor = false;
            this.tnSc3.Click += new System.EventHandler(this.tnSc3_Click);
            // 
            // tnSc2
            // 
            this.tnSc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tnSc2.FlatAppearance.BorderSize = 0;
            this.tnSc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnSc2.Font = new System.Drawing.Font("Myriad Pro Cond", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnSc2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tnSc2.Location = new System.Drawing.Point(8, 40);
            this.tnSc2.Name = "tnSc2";
            this.tnSc2.Size = new System.Drawing.Size(86, 23);
            this.tnSc2.TabIndex = 0;
            this.tnSc2.Text = "neutral";
            this.tnSc2.UseVisualStyleBackColor = false;
            this.tnSc2.Click += new System.EventHandler(this.tnSc2_Click);
            // 
            // tone_togle
            // 
            this.tone_togle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tone_togle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tone_togle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tone_togle.ForeColor = System.Drawing.Color.White;
            this.tone_togle.Location = new System.Drawing.Point(0, 0);
            this.tone_togle.Name = "tone_togle";
            this.tone_togle.Size = new System.Drawing.Size(106, 23);
            this.tone_togle.TabIndex = 0;
            this.tone_togle.Text = "Tones";
            this.tone_togle.UseVisualStyleBackColor = false;
            this.tone_togle.Click += new System.EventHandler(this.tone_togle_Click);
            // 
            // alpha
            // 
            this.alpha.AutoSize = false;
            this.alpha.Location = new System.Drawing.Point(208, 295);
            this.alpha.Maximum = 255;
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(145, 20);
            this.alpha.TabIndex = 8;
            this.alpha.Tag = "";
            this.alpha.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::colorPiker.Properties.Resources.colorizer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // copy_btn
            // 
            this.copy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.copy_btn.FlatAppearance.BorderSize = 0;
            this.copy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_btn.ForeColor = System.Drawing.Color.White;
            this.copy_btn.Image = global::colorPiker.Properties.Resources.icons8_copy_24px;
            this.copy_btn.Location = new System.Drawing.Point(322, 166);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(31, 29);
            this.copy_btn.TabIndex = 3;
            this.copy_btn.UseVisualStyleBackColor = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // ton_scale
            // 
            this.ton_scale.AutoSize = true;
            this.ton_scale.BackColor = System.Drawing.Color.Transparent;
            this.ton_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ton_scale.Location = new System.Drawing.Point(24, 295);
            this.ton_scale.Name = "ton_scale";
            this.ton_scale.Size = new System.Drawing.Size(40, 17);
            this.ton_scale.TabIndex = 3;
            this.ton_scale.Text = "none";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tone Scale :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(465, 315);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toHSV);
            this.Controls.Add(this.toRGB);
            this.Controls.Add(this.rec3);
            this.Controls.Add(this.rec2);
            this.Controls.Add(this.rec1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.clr_code);
            this.Controls.Add(this.clr_view);
            this.Controls.Add(this.blue_scale);
            this.Controls.Add(this.green_scale);
            this.Controls.Add(this.red_scale);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colorizer";
            ((System.ComponentModel.ISupportInitialize)(this.red_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_scale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tone_sec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar red_scale;
        private System.Windows.Forms.TrackBar green_scale;
        private System.Windows.Forms.TrackBar blue_scale;
        private System.Windows.Forms.Panel clr_view;
        private System.Windows.Forms.Label clr_code;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rec1;
        private System.Windows.Forms.TextBox rec2;
        private System.Windows.Forms.TextBox rec3;
        private System.Windows.Forms.Button toRGB;
        private System.Windows.Forms.Button toHSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tone_togle;
        private System.Windows.Forms.Panel tone_sec;
        private System.Windows.Forms.Button tnSc1;
        private System.Windows.Forms.Button tnSc4;
        private System.Windows.Forms.Button tnSc5;
        private System.Windows.Forms.Button tnSc3;
        private System.Windows.Forms.Button tnSc2;
        private System.Windows.Forms.Button tnSc6;
        private System.Windows.Forms.TrackBar alpha;
        private System.Windows.Forms.Button tnSc7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ton_scale;
        private System.Windows.Forms.Label label4;
    }
}

