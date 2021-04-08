
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
            this.red_scale = new System.Windows.Forms.TrackBar();
            this.green_scale = new System.Windows.Forms.TrackBar();
            this.blue_scale = new System.Windows.Forms.TrackBar();
            this.clr_view = new System.Windows.Forms.Panel();
            this.clr_code = new System.Windows.Forms.Label();
            this.copy_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rec1 = new System.Windows.Forms.TextBox();
            this.rec2 = new System.Windows.Forms.TextBox();
            this.rec3 = new System.Windows.Forms.TextBox();
            this.toRGB = new System.Windows.Forms.Button();
            this.toHSV = new System.Windows.Forms.Button();
            cntClk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.red_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_scale)).BeginInit();
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
            this.clr_code.Location = new System.Drawing.Point(208, 166);
            this.clr_code.Name = "clr_code";
            this.clr_code.Size = new System.Drawing.Size(108, 23);
            this.clr_code.TabIndex = 2;
            this.clr_code.Text = "#000000";
            this.clr_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.rec1.TextChanged += new System.EventHandler(this.rec1_TextChanged);
            // 
            // rec2
            // 
            this.rec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec2.Location = new System.Drawing.Point(54, 282);
            this.rec2.Name = "rec2";
            this.rec2.Size = new System.Drawing.Size(37, 29);
            this.rec2.TabIndex = 5;
            this.rec2.TextChanged += new System.EventHandler(this.rec2_TextChanged);
            // 
            // rec3
            // 
            this.rec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec3.Location = new System.Drawing.Point(99, 282);
            this.rec3.Name = "rec3";
            this.rec3.Size = new System.Drawing.Size(37, 29);
            this.rec3.TabIndex = 5;
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
            this.toRGB.Location = new System.Drawing.Point(229, 251);
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
            this.toHSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toHSV.Location = new System.Drawing.Point(284, 251);
            this.toHSV.Name = "toHSV";
            this.toHSV.Size = new System.Drawing.Size(49, 31);
            this.toHSV.TabIndex = 6;
            this.toHSV.Text = "HSV";
            this.toHSV.UseVisualStyleBackColor = false;
            this.toHSV.Click += new System.EventHandler(this.toHSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(418, 315);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colorizer";
            ((System.ComponentModel.ISupportInitialize)(this.red_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_scale)).EndInit();
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
    }
}

