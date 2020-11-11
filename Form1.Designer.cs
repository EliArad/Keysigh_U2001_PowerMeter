namespace KeysightU2001App
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
            this.rbIVI = new System.Windows.Forms.RadioButton();
            this.rbSCPI = new System.Windows.Forms.RadioButton();
            this.powerMeterControl5 = new KeysightU2001App.PowerMeterControl();
            this.powerMeterControl4 = new KeysightU2001App.PowerMeterControl();
            this.powerMeterControl3 = new KeysightU2001App.PowerMeterControl();
            this.powerMeterControl2 = new KeysightU2001App.PowerMeterControl();
            this.powerMeterControl1 = new KeysightU2001App.PowerMeterControl();
            this.SuspendLayout();
            // 
            // rbIVI
            // 
            this.rbIVI.AutoSize = true;
            this.rbIVI.Checked = true;
            this.rbIVI.Location = new System.Drawing.Point(26, 517);
            this.rbIVI.Name = "rbIVI";
            this.rbIVI.Size = new System.Drawing.Size(38, 17);
            this.rbIVI.TabIndex = 5;
            this.rbIVI.TabStop = true;
            this.rbIVI.Text = "IVI";
            this.rbIVI.UseVisualStyleBackColor = true;
            // 
            // rbSCPI
            // 
            this.rbSCPI.AutoSize = true;
            this.rbSCPI.Location = new System.Drawing.Point(106, 516);
            this.rbSCPI.Name = "rbSCPI";
            this.rbSCPI.Size = new System.Drawing.Size(49, 17);
            this.rbSCPI.TabIndex = 6;
            this.rbSCPI.Text = "SCPI";
            this.rbSCPI.UseVisualStyleBackColor = true;
            // 
            // powerMeterControl5
            // 
            this.powerMeterControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.powerMeterControl5.Location = new System.Drawing.Point(12, 420);
            this.powerMeterControl5.Name = "powerMeterControl5";
            this.powerMeterControl5.Size = new System.Drawing.Size(672, 90);
            this.powerMeterControl5.TabIndex = 4;
            // 
            // powerMeterControl4
            // 
            this.powerMeterControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.powerMeterControl4.Location = new System.Drawing.Point(12, 320);
            this.powerMeterControl4.Name = "powerMeterControl4";
            this.powerMeterControl4.Size = new System.Drawing.Size(672, 90);
            this.powerMeterControl4.TabIndex = 3;
            // 
            // powerMeterControl3
            // 
            this.powerMeterControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.powerMeterControl3.Location = new System.Drawing.Point(12, 215);
            this.powerMeterControl3.Name = "powerMeterControl3";
            this.powerMeterControl3.Size = new System.Drawing.Size(672, 90);
            this.powerMeterControl3.TabIndex = 2;
            // 
            // powerMeterControl2
            // 
            this.powerMeterControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.powerMeterControl2.Location = new System.Drawing.Point(12, 119);
            this.powerMeterControl2.Name = "powerMeterControl2";
            this.powerMeterControl2.Size = new System.Drawing.Size(672, 90);
            this.powerMeterControl2.TabIndex = 1;
            // 
            // powerMeterControl1
            // 
            this.powerMeterControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.powerMeterControl1.Location = new System.Drawing.Point(12, 12);
            this.powerMeterControl1.Name = "powerMeterControl1";
            this.powerMeterControl1.Size = new System.Drawing.Size(672, 90);
            this.powerMeterControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 533);
            this.Controls.Add(this.rbSCPI);
            this.Controls.Add(this.rbIVI);
            this.Controls.Add(this.powerMeterControl5);
            this.Controls.Add(this.powerMeterControl4);
            this.Controls.Add(this.powerMeterControl3);
            this.Controls.Add(this.powerMeterControl2);
            this.Controls.Add(this.powerMeterControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PowerMeterControl powerMeterControl1;
        private PowerMeterControl powerMeterControl2;
        private PowerMeterControl powerMeterControl3;
        private PowerMeterControl powerMeterControl4;
        private PowerMeterControl powerMeterControl5;
        private System.Windows.Forms.RadioButton rbIVI;
        private System.Windows.Forms.RadioButton rbSCPI;
    }
}

