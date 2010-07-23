namespace Client_Tracker
{
    partial class GetClient
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ClientReady = new System.Windows.Forms.Button();
            this.grpBox_addClient = new System.Windows.Forms.GroupBox();
            this.grpBox_existingClient = new System.Windows.Forms.GroupBox();
            this.grpBox_addClient.SuspendLayout();
            this.grpBox_existingClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // btn_ClientReady
            // 
            this.btn_ClientReady.Location = new System.Drawing.Point(23, 204);
            this.btn_ClientReady.Name = "btn_ClientReady";
            this.btn_ClientReady.Size = new System.Drawing.Size(138, 23);
            this.btn_ClientReady.TabIndex = 6;
            this.btn_ClientReady.Text = "Load Client";
            this.btn_ClientReady.UseVisualStyleBackColor = true;
            // 
            // grpBox_addClient
            // 
            this.grpBox_addClient.Controls.Add(this.label2);
            this.grpBox_addClient.Controls.Add(this.textBox1);
            this.grpBox_addClient.Controls.Add(this.label3);
            this.grpBox_addClient.Controls.Add(this.textBox2);
            this.grpBox_addClient.Location = new System.Drawing.Point(11, 62);
            this.grpBox_addClient.Name = "grpBox_addClient";
            this.grpBox_addClient.Size = new System.Drawing.Size(170, 136);
            this.grpBox_addClient.TabIndex = 7;
            this.grpBox_addClient.TabStop = false;
            this.grpBox_addClient.Text = "New Client";
            // 
            // grpBox_existingClient
            // 
            this.grpBox_existingClient.Controls.Add(this.comboBox1);
            this.grpBox_existingClient.Location = new System.Drawing.Point(11, 6);
            this.grpBox_existingClient.Name = "grpBox_existingClient";
            this.grpBox_existingClient.Size = new System.Drawing.Size(170, 50);
            this.grpBox_existingClient.TabIndex = 8;
            this.grpBox_existingClient.TabStop = false;
            this.grpBox_existingClient.Text = "Existing Client";
            // 
            // GetClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBox_existingClient);
            this.Controls.Add(this.grpBox_addClient);
            this.Controls.Add(this.btn_ClientReady);
            this.Name = "GetClient";
            this.Size = new System.Drawing.Size(194, 241);
            this.grpBox_addClient.ResumeLayout(false);
            this.grpBox_addClient.PerformLayout();
            this.grpBox_existingClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ClientReady;
        private System.Windows.Forms.GroupBox grpBox_addClient;
        private System.Windows.Forms.GroupBox grpBox_existingClient;
    }
}
