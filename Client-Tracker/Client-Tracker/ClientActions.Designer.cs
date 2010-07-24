﻿namespace Client_Tracker
{
    partial class ClientActions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox_notes = new System.Windows.Forms.GroupBox();
            this.btn_submitEntry = new System.Windows.Forms.Button();
            this.btn_StartTime = new System.Windows.Forms.Button();
            this.btn_stopTime = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_pauseAndHold = new System.Windows.Forms.Button();
            this.grpBox_typeOfWork = new System.Windows.Forms.GroupBox();
            this.cmbBox_typeOfWorkDone = new System.Windows.Forms.ComboBox();
            this.digitalDisplay1 = new DigitalClock.DigitalDisplay();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBox_notes.SuspendLayout();
            this.grpBox_typeOfWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_stopTime);
            this.groupBox1.Controls.Add(this.btn_StartTime);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // grpBox_notes
            // 
            this.grpBox_notes.Controls.Add(this.textBox1);
            this.grpBox_notes.Location = new System.Drawing.Point(9, 182);
            this.grpBox_notes.Name = "grpBox_notes";
            this.grpBox_notes.Size = new System.Drawing.Size(291, 131);
            this.grpBox_notes.TabIndex = 1;
            this.grpBox_notes.TabStop = false;
            this.grpBox_notes.Text = "Notes";
            // 
            // btn_submitEntry
            // 
            this.btn_submitEntry.Location = new System.Drawing.Point(318, 290);
            this.btn_submitEntry.Name = "btn_submitEntry";
            this.btn_submitEntry.Size = new System.Drawing.Size(95, 23);
            this.btn_submitEntry.TabIndex = 2;
            this.btn_submitEntry.Text = "Submit Work";
            this.btn_submitEntry.UseVisualStyleBackColor = true;
            // 
            // btn_StartTime
            // 
            this.btn_StartTime.Location = new System.Drawing.Point(6, 19);
            this.btn_StartTime.Name = "btn_StartTime";
            this.btn_StartTime.Size = new System.Drawing.Size(75, 23);
            this.btn_StartTime.TabIndex = 0;
            this.btn_StartTime.Text = "Start";
            this.btn_StartTime.UseVisualStyleBackColor = true;
            this.btn_StartTime.Click += new System.EventHandler(this.btn_StartTime_Click);
            // 
            // btn_stopTime
            // 
            this.btn_stopTime.Location = new System.Drawing.Point(87, 19);
            this.btn_stopTime.Name = "btn_stopTime";
            this.btn_stopTime.Size = new System.Drawing.Size(75, 23);
            this.btn_stopTime.TabIndex = 1;
            this.btn_stopTime.Text = "Stop";
            this.btn_stopTime.UseVisualStyleBackColor = true;
            this.btn_stopTime.Click += new System.EventHandler(this.btn_stopTime_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 106);
            this.textBox1.TabIndex = 0;
            // 
            // btn_pauseAndHold
            // 
            this.btn_pauseAndHold.Location = new System.Drawing.Point(9, 319);
            this.btn_pauseAndHold.Name = "btn_pauseAndHold";
            this.btn_pauseAndHold.Size = new System.Drawing.Size(156, 23);
            this.btn_pauseAndHold.TabIndex = 3;
            this.btn_pauseAndHold.Text = "Pause and Move to Hold";
            this.btn_pauseAndHold.UseVisualStyleBackColor = true;
            // 
            // grpBox_typeOfWork
            // 
            this.grpBox_typeOfWork.Controls.Add(this.cmbBox_typeOfWorkDone);
            this.grpBox_typeOfWork.Location = new System.Drawing.Point(3, 61);
            this.grpBox_typeOfWork.Name = "grpBox_typeOfWork";
            this.grpBox_typeOfWork.Size = new System.Drawing.Size(280, 61);
            this.grpBox_typeOfWork.TabIndex = 4;
            this.grpBox_typeOfWork.TabStop = false;
            this.grpBox_typeOfWork.Text = "Type Of Work Done";
            // 
            // cmbBox_typeOfWorkDone
            // 
            this.cmbBox_typeOfWorkDone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_typeOfWorkDone.FormattingEnabled = true;
            this.cmbBox_typeOfWorkDone.Location = new System.Drawing.Point(12, 19);
            this.cmbBox_typeOfWorkDone.Name = "cmbBox_typeOfWorkDone";
            this.cmbBox_typeOfWorkDone.Size = new System.Drawing.Size(150, 21);
            this.cmbBox_typeOfWorkDone.TabIndex = 0;
            // 
            // digitalDisplay1
            // 
            this.digitalDisplay1.CountDown = true;
            this.digitalDisplay1.Hours = "00";
            this.digitalDisplay1.Location = new System.Drawing.Point(302, 69);
            this.digitalDisplay1.Minutes = "00";
            this.digitalDisplay1.Name = "digitalDisplay1";
            this.digitalDisplay1.Seconds = "00";
            this.digitalDisplay1.Size = new System.Drawing.Size(150, 53);
            this.digitalDisplay1.TabIndex = 5;
            this.digitalDisplay1.UseWindowColours = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(216, 19);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(58, 23);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ClientActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.digitalDisplay1);
            this.Controls.Add(this.grpBox_typeOfWork);
            this.Controls.Add(this.btn_pauseAndHold);
            this.Controls.Add(this.btn_submitEntry);
            this.Controls.Add(this.grpBox_notes);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientActions";
            this.Size = new System.Drawing.Size(490, 368);
            this.groupBox1.ResumeLayout(false);
            this.grpBox_notes.ResumeLayout(false);
            this.grpBox_notes.PerformLayout();
            this.grpBox_typeOfWork.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_stopTime;
        private System.Windows.Forms.Button btn_StartTime;
        private System.Windows.Forms.GroupBox grpBox_notes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_submitEntry;
        private System.Windows.Forms.Button btn_pauseAndHold;
        private System.Windows.Forms.GroupBox grpBox_typeOfWork;
        private System.Windows.Forms.ComboBox cmbBox_typeOfWorkDone;
        private DigitalClock.DigitalDisplay digitalDisplay1;
        private System.Windows.Forms.Button btn_reset;
    }
}