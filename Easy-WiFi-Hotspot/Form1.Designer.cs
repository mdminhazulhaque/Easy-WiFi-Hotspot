namespace Easy_WiFi_Hotspot
{
    partial class FormMain
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelSSID = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textSSID = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(170, 61);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(62, 25);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(71, 61);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(93, 25);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Test Device";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSSID
            // 
            this.labelSSID.AutoSize = true;
            this.labelSSID.Location = new System.Drawing.Point(12, 16);
            this.labelSSID.Name = "labelSSID";
            this.labelSSID.Size = new System.Drawing.Size(32, 13);
            this.labelSSID.TabIndex = 0;
            this.labelSSID.Text = "SSID";
            this.labelSSID.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(238, 61);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(62, 25);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 38);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // textSSID
            // 
            this.textSSID.Location = new System.Drawing.Point(71, 9);
            this.textSSID.Name = "textSSID";
            this.textSSID.Size = new System.Drawing.Size(229, 20);
            this.textSSID.TabIndex = 1;
            this.textSSID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(71, 35);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(229, 20);
            this.textPassword.TabIndex = 3;
            this.textPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 104);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textSSID);
            this.Controls.Add(this.labelSSID);
            this.Controls.Add(this.labelPassword);
            this.Name = "FormMain";
            this.Text = "Easy WiFi Hotspot";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelSSID;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textSSID;
        private System.Windows.Forms.TextBox textPassword;
    }
}

