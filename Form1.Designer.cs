
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
            cntClk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.red_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_scale)).BeginInit();
            this.SuspendLayout();
            // 
            // red_scale
            // 
            this.red_scale.AutoSize = false;
            this.red_scale.BackColor = System.Drawing.Color.Red;
            this.red_scale.Location = new System.Drawing.Point(9, 9);
            this.red_scale.Margin = new System.Windows.Forms.Padding(0);
            this.red_scale.Maximum = 255;
            this.red_scale.Name = "red_scale";
            this.red_scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.red_scale.Size = new System.Drawing.Size(19, 226);
            this.red_scale.SmallChange = 0;
            this.red_scale.TabIndex = 0;
            this.red_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // green_scale
            // 
            this.green_scale.AutoSize = false;
            this.green_scale.BackColor = System.Drawing.Color.Lime;
            this.green_scale.Location = new System.Drawing.Point(51, 9);
            this.green_scale.Margin = new System.Windows.Forms.Padding(0);
            this.green_scale.Maximum = 255;
            this.green_scale.Name = "green_scale";
            this.green_scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.green_scale.Size = new System.Drawing.Size(19, 226);
            this.green_scale.SmallChange = 0;
            this.green_scale.TabIndex = 0;
            this.green_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // blue_scale
            // 
            this.blue_scale.AutoSize = false;
            this.blue_scale.BackColor = System.Drawing.Color.Blue;
            this.blue_scale.Location = new System.Drawing.Point(100, 9);
            this.blue_scale.Margin = new System.Windows.Forms.Padding(0);
            this.blue_scale.Maximum = 255;
            this.blue_scale.Name = "blue_scale";
            this.blue_scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blue_scale.Size = new System.Drawing.Size(19, 226);
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
            // cntClk
            // 
            cntClk.Enabled = true;
            cntClk.Interval = 10;
            cntClk.Tick += new System.EventHandler(this.cntClk_Tick);
            // 
            // clr_code
            // 
            this.clr_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clr_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_code.ForeColor = System.Drawing.Color.White;
            this.clr_code.Location = new System.Drawing.Point(188, 166);
            this.clr_code.Name = "clr_code";
            this.clr_code.Size = new System.Drawing.Size(190, 23);
            this.clr_code.TabIndex = 2;
            this.clr_code.Text = "clr_code";
            this.clr_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copy_btn
            // 
            this.copy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.copy_btn.FlatAppearance.BorderSize = 0;
            this.copy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_btn.ForeColor = System.Drawing.Color.White;
            this.copy_btn.Location = new System.Drawing.Point(246, 212);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(60, 23);
            this.copy_btn.TabIndex = 3;
            this.copy_btn.Text = "COPY";
            this.copy_btn.UseVisualStyleBackColor = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(418, 244);
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

        }

        #endregion

        private System.Windows.Forms.TrackBar red_scale;
        private System.Windows.Forms.TrackBar green_scale;
        private System.Windows.Forms.TrackBar blue_scale;
        private System.Windows.Forms.Panel clr_view;
        private System.Windows.Forms.Label clr_code;
        private System.Windows.Forms.Button copy_btn;
    }
}

