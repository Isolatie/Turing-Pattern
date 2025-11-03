namespace Turing
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
            this.end_time_bar = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.d0_bar = new System.Windows.Forms.NumericUpDown();
            this.RandLabel = new System.Windows.Forms.Label();
            this.d1_bar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.TuringPicturebox = new System.Windows.Forms.PictureBox();
            this.SizeN = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.timestep_bar = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorbutton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.colorbutton2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SizeM = new System.Windows.Forms.NumericUpDown();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.end_time_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d0_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuringPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timestep_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeM)).BeginInit();
            this.SuspendLayout();
            // 
            // end_time_bar
            // 
            this.end_time_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.end_time_bar.AutoSize = true;
            this.end_time_bar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_time_bar.Location = new System.Drawing.Point(788, 59);
            this.end_time_bar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.end_time_bar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.end_time_bar.Name = "end_time_bar";
            this.end_time_bar.Size = new System.Drawing.Size(250, 29);
            this.end_time_bar.TabIndex = 0;
            this.end_time_bar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.end_time_bar.ValueChanged += new System.EventHandler(this.EndTime);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.AutoSize = true;
            this.StartButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StartButton.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(788, 442);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(250, 86);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.Start_Button);
            // 
            // d0_bar
            // 
            this.d0_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.d0_bar.AutoSize = true;
            this.d0_bar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d0_bar.Location = new System.Drawing.Point(788, 232);
            this.d0_bar.Name = "d0_bar";
            this.d0_bar.Size = new System.Drawing.Size(99, 29);
            this.d0_bar.TabIndex = 2;
            this.d0_bar.ValueChanged += new System.EventHandler(this.d0_value);
            // 
            // RandLabel
            // 
            this.RandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RandLabel.AutoSize = true;
            this.RandLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RandLabel.Location = new System.Drawing.Point(848, 21);
            this.RandLabel.Name = "RandLabel";
            this.RandLabel.Size = new System.Drawing.Size(125, 31);
            this.RandLabel.TabIndex = 4;
            this.RandLabel.Text = "End Time";
            // 
            // d1_bar
            // 
            this.d1_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.d1_bar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1_bar.Location = new System.Drawing.Point(938, 232);
            this.d1_bar.Name = "d1_bar";
            this.d1_bar.Size = new System.Drawing.Size(99, 29);
            this.d1_bar.TabIndex = 5;
            this.d1_bar.ValueChanged += new System.EventHandler(this.d1_value);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(817, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "d0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(966, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "d1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(848, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Timestep";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorLabel.Location = new System.Drawing.Point(798, 294);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(89, 31);
            this.ColorLabel.TabIndex = 10;
            this.ColorLabel.Text = "Color 1";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TuringPicturebox
            // 
            this.TuringPicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TuringPicturebox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TuringPicturebox.Location = new System.Drawing.Point(12, 12);
            this.TuringPicturebox.Name = "TuringPicturebox";
            this.TuringPicturebox.Size = new System.Drawing.Size(764, 507);
            this.TuringPicturebox.TabIndex = 12;
            this.TuringPicturebox.TabStop = false;
            // 
            // SizeN
            // 
            this.SizeN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeN.AutoSize = true;
            this.SizeN.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeN.Location = new System.Drawing.Point(789, 407);
            this.SizeN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SizeN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeN.Name = "SizeN";
            this.SizeN.Size = new System.Drawing.Size(100, 29);
            this.SizeN.TabIndex = 13;
            this.SizeN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeN.ValueChanged += new System.EventHandler(this.SizeN_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(817, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "N";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timestep_bar
            // 
            this.timestep_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timestep_bar.AutoSize = true;
            this.timestep_bar.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timestep_bar.Location = new System.Drawing.Point(789, 153);
            this.timestep_bar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timestep_bar.Name = "timestep_bar";
            this.timestep_bar.Size = new System.Drawing.Size(250, 29);
            this.timestep_bar.TabIndex = 15;
            this.timestep_bar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timestep_bar.ValueChanged += new System.EventHandler(this.TimeStep);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.OrangeRed;
            // 
            // colorbutton1
            // 
            this.colorbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorbutton1.AutoSize = true;
            this.colorbutton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorbutton1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorbutton1.Location = new System.Drawing.Point(788, 328);
            this.colorbutton1.Name = "colorbutton1";
            this.colorbutton1.Size = new System.Drawing.Size(99, 38);
            this.colorbutton1.TabIndex = 16;
            this.colorbutton1.Text = "Click";
            this.colorbutton1.UseVisualStyleBackColor = false;
            this.colorbutton1.Click += new System.EventHandler(this.color1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(942, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorbutton2
            // 
            this.colorbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorbutton2.AutoSize = true;
            this.colorbutton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorbutton2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorbutton2.Location = new System.Drawing.Point(938, 328);
            this.colorbutton2.Name = "colorbutton2";
            this.colorbutton2.Size = new System.Drawing.Size(99, 38);
            this.colorbutton2.TabIndex = 18;
            this.colorbutton2.Text = "Click";
            this.colorbutton2.UseVisualStyleBackColor = false;
            this.colorbutton2.Click += new System.EventHandler(this.color2);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(970, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "M";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SizeM
            // 
            this.SizeM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeM.AutoSize = true;
            this.SizeM.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeM.Location = new System.Drawing.Point(939, 407);
            this.SizeM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SizeM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeM.Name = "SizeM";
            this.SizeM.Size = new System.Drawing.Size(100, 29);
            this.SizeM.TabIndex = 20;
            this.SizeM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeM.ValueChanged += new System.EventHandler(this.SizeM_ValueChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(12, 525);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(764, 12);
            this.ProgressBar.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1049, 540);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.SizeM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorbutton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colorbutton1);
            this.Controls.Add(this.timestep_bar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SizeN);
            this.Controls.Add(this.TuringPicturebox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d1_bar);
            this.Controls.Add(this.RandLabel);
            this.Controls.Add(this.d0_bar);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.end_time_bar);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Turing Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.end_time_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d0_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuringPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timestep_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown end_time_bar;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown d0_bar;
        private System.Windows.Forms.Label RandLabel;
        private System.Windows.Forms.NumericUpDown d1_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.PictureBox TuringPicturebox;
        private System.Windows.Forms.NumericUpDown SizeN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown timestep_bar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorbutton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button colorbutton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SizeM;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

