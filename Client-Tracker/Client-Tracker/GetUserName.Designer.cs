﻿namespace Client_Tracker
{
    partial class GetUserName
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
            this.btn_registerUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_firstName = new System.Windows.Forms.TextBox();
            this.txtBox_lastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_registerUser
            // 
            this.btn_registerUser.Location = new System.Drawing.Point(85, 92);
            this.btn_registerUser.Name = "btn_registerUser";
            this.btn_registerUser.Size = new System.Drawing.Size(95, 23);
            this.btn_registerUser.TabIndex = 0;
            this.btn_registerUser.Text = "Register User";
            this.btn_registerUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtBox_firstName
            // 
            this.txtBox_firstName.Location = new System.Drawing.Point(73, 29);
            this.txtBox_firstName.Name = "txtBox_firstName";
            this.txtBox_firstName.Size = new System.Drawing.Size(137, 20);
            this.txtBox_firstName.TabIndex = 3;
            // 
            // txtBox_lastName
            // 
            this.txtBox_lastName.Location = new System.Drawing.Point(73, 55);
            this.txtBox_lastName.Name = "txtBox_lastName";
            this.txtBox_lastName.Size = new System.Drawing.Size(137, 20);
            this.txtBox_lastName.TabIndex = 4;
            // 
            // GetUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.txtBox_lastName);
            this.Controls.Add(this.txtBox_firstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_registerUser);
            this.Name = "GetUserName";
            this.Text = "GetUserName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_registerUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_firstName;
        private System.Windows.Forms.TextBox txtBox_lastName;
    }
}