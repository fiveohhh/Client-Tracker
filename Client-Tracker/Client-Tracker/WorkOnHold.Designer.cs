namespace Client_Tracker
{
    partial class WorkOnHold
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_activate = new System.Windows.Forms.Button();
            this.digitalDisplay1 = new DigitalClock.DigitalDisplay();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            // 
            // btn_activate
            // 
            this.btn_activate.Location = new System.Drawing.Point(186, 3);
            this.btn_activate.Name = "btn_activate";
            this.btn_activate.Size = new System.Drawing.Size(57, 23);
            this.btn_activate.TabIndex = 1;
            this.btn_activate.Text = "Activate";
            this.btn_activate.UseVisualStyleBackColor = true;
            // 
            // digitalDisplay1
            // 
            this.digitalDisplay1.CountDown = true;
            this.digitalDisplay1.Hours = "00";
            this.digitalDisplay1.Location = new System.Drawing.Point(6, 16);
            this.digitalDisplay1.Minutes = "00";
            this.digitalDisplay1.Name = "digitalDisplay1";
            this.digitalDisplay1.Seconds = "00";
            this.digitalDisplay1.Size = new System.Drawing.Size(94, 30);
            this.digitalDisplay1.TabIndex = 2;
            this.digitalDisplay1.UseWindowColours = false;
            // 
            // WorkOnHold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.digitalDisplay1);
            this.Controls.Add(this.btn_activate);
            this.Controls.Add(this.lbl_name);
            this.Name = "WorkOnHold";
            this.Size = new System.Drawing.Size(246, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_activate;
        private DigitalClock.DigitalDisplay digitalDisplay1;
    }
}
