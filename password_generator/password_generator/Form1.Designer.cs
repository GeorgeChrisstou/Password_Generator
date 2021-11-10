
using System;

namespace password_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.password_label = new System.Windows.Forms.Label();
            this.passwordlength = new System.Windows.Forms.Label();
            this.passwordlengthtrackbar = new System.Windows.Forms.TrackBar();
            this.copypassword = new System.Windows.Forms.Button();
            this.upper = new System.Windows.Forms.CheckBox();
            this.lower = new System.Windows.Forms.CheckBox();
            this.nums = new System.Windows.Forms.CheckBox();
            this.syms = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordlengthtrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // password_label
            // 
            this.password_label.Location = new System.Drawing.Point(55, 67);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(238, 39);
            this.password_label.TabIndex = 0;
            this.password_label.Text = "label1";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordlength
            // 
            this.passwordlength.Location = new System.Drawing.Point(55, 198);
            this.passwordlength.Name = "passwordlength";
            this.passwordlength.Size = new System.Drawing.Size(238, 39);
            this.passwordlength.TabIndex = 1;
            this.passwordlength.Text = "Password Length: 6";
            this.passwordlength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordlengthtrackbar
            // 
            this.passwordlengthtrackbar.Location = new System.Drawing.Point(55, 288);
            this.passwordlengthtrackbar.Name = "passwordlengthtrackbar";
            this.passwordlengthtrackbar.Size = new System.Drawing.Size(238, 56);
            this.passwordlengthtrackbar.TabIndex = 2;
            this.passwordlengthtrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // copypassword
            // 
            this.copypassword.Location = new System.Drawing.Point(439, 373);
            this.copypassword.Name = "copypassword";
            this.copypassword.Size = new System.Drawing.Size(238, 29);
            this.copypassword.TabIndex = 3;
            this.copypassword.Text = "Copy password";
            this.copypassword.UseVisualStyleBackColor = true;
            this.copypassword.Click += new System.EventHandler(this.copypassword_Click);
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Location = new System.Drawing.Point(528, 75);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(149, 24);
            this.upper.TabIndex = 4;
            this.upper.Text = "Uppercase Letters\r\n";
            this.upper.UseVisualStyleBackColor = true;
            this.upper.CheckedChanged += new System.EventHandler(this.upper_CheckedChanged);
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Location = new System.Drawing.Point(528, 105);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(148, 24);
            this.lower.TabIndex = 5;
            this.lower.Text = "Lowercase Letters";
            this.lower.UseVisualStyleBackColor = true;
            this.lower.CheckedChanged += new System.EventHandler(this.lower_CheckedChanged);
            // 
            // nums
            // 
            this.nums.AutoSize = true;
            this.nums.Location = new System.Drawing.Point(528, 135);
            this.nums.Name = "nums";
            this.nums.Size = new System.Drawing.Size(91, 24);
            this.nums.TabIndex = 6;
            this.nums.Text = "Numbers";
            this.nums.UseVisualStyleBackColor = true;
            this.nums.CheckedChanged += new System.EventHandler(this.nums_CheckedChanged);
            // 
            // syms
            // 
            this.syms.AutoSize = true;
            this.syms.Location = new System.Drawing.Point(528, 165);
            this.syms.Name = "syms";
            this.syms.Size = new System.Drawing.Size(87, 24);
            this.syms.TabIndex = 7;
            this.syms.Text = "Symbols";
            this.syms.UseVisualStyleBackColor = true;
            this.syms.CheckedChanged += new System.EventHandler(this.syms_CheckedChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(55, 373);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(238, 29);
            this.password.TabIndex = 8;
            this.password.Text = "Generate password";
            this.password.UseVisualStyleBackColor = true;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.syms);
            this.Controls.Add(this.nums);
            this.Controls.Add(this.lower);
            this.Controls.Add(this.upper);
            this.Controls.Add(this.copypassword);
            this.Controls.Add(this.passwordlengthtrackbar);
            this.Controls.Add(this.passwordlength);
            this.Controls.Add(this.password_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordlengthtrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void generate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label passwordlength;
        private System.Windows.Forms.TrackBar passwordlengthtrackbar;
        private System.Windows.Forms.Button copypassword;
        private System.Windows.Forms.CheckBox upper;
        private System.Windows.Forms.CheckBox lower;
        private System.Windows.Forms.CheckBox nums;
        private System.Windows.Forms.CheckBox syms;
        private System.Windows.Forms.Button password;
    }
}

