﻿namespace NICApp
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtVote = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtIDNumber = new NICTextBox.NICTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIC Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vote Eligibity";
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(255, 217);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(155, 22);
            this.txtGender.TabIndex = 6;
            this.txtGender.TextChanged += new System.EventHandler(this.txtGender_TextChanged);
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Enabled = false;
            this.txtDateOfBirth.Location = new System.Drawing.Point(255, 261);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(155, 22);
            this.txtDateOfBirth.TabIndex = 7;
            // 
            // txtVote
            // 
            this.txtVote.Enabled = false;
            this.txtVote.Location = new System.Drawing.Point(255, 301);
            this.txtVote.Name = "txtVote";
            this.txtVote.Size = new System.Drawing.Size(155, 22);
            this.txtVote.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(151, 108);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 53);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next Person";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.BackColor = System.Drawing.Color.LightYellow;
            this.txtIDNumber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtIDNumber.HasDecimal = true;
            this.txtIDNumber.HasNegative = false;
            this.txtIDNumber.Location = new System.Drawing.Point(202, 38);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(184, 22);
            this.txtIDNumber.TabIndex = 13;
            this.txtIDNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Add_KeyUp);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 413);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtVote);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "NIC Personal Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtVote;
        private System.Windows.Forms.Button btnNext;
        private NICTextBox.NICTextBox txtIDNumber;
    }
}

