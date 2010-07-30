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
            this.cmbBox_existingClients = new System.Windows.Forms.ComboBox();
            this.txtBox_firstName = new System.Windows.Forms.TextBox();
            this.txtBox_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ClientReady = new System.Windows.Forms.Button();
            this.grpBox_addClient = new System.Windows.Forms.GroupBox();
            this.chkBox_newClient = new System.Windows.Forms.CheckBox();
            this.grpBox_existingClient = new System.Windows.Forms.GroupBox();
            this.grpBox_addClient.SuspendLayout();
            this.grpBox_existingClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBox_existingClients
            // 
            this.cmbBox_existingClients.FormattingEnabled = true;
            this.cmbBox_existingClients.Location = new System.Drawing.Point(12, 19);
            this.cmbBox_existingClients.Name = "cmbBox_existingClients";
            this.cmbBox_existingClients.Size = new System.Drawing.Size(152, 21);
            this.cmbBox_existingClients.TabIndex = 0;
            // 
            // txtBox_firstName
            // 
            this.txtBox_firstName.Location = new System.Drawing.Point(12, 30);
            this.txtBox_firstName.Name = "txtBox_firstName";
            this.txtBox_firstName.Size = new System.Drawing.Size(138, 20);
            this.txtBox_firstName.TabIndex = 2;
            // 
            // txtBox_lastName
            // 
            this.txtBox_lastName.Location = new System.Drawing.Point(12, 76);
            this.txtBox_lastName.Name = "txtBox_lastName";
            this.txtBox_lastName.Size = new System.Drawing.Size(138, 20);
            this.txtBox_lastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // btn_ClientReady
            // 
            this.btn_ClientReady.Location = new System.Drawing.Point(23, 204);
            this.btn_ClientReady.Name = "btn_ClientReady";
            this.btn_ClientReady.Size = new System.Drawing.Size(138, 23);
            this.btn_ClientReady.TabIndex = 2;
            this.btn_ClientReady.Text = "Load Client";
            this.btn_ClientReady.UseVisualStyleBackColor = true;
            this.btn_ClientReady.Click += new System.EventHandler(this.btn_ClientReady_Click);
            // 
            // grpBox_addClient
            // 
            this.grpBox_addClient.Controls.Add(this.chkBox_newClient);
            this.grpBox_addClient.Controls.Add(this.label2);
            this.grpBox_addClient.Controls.Add(this.txtBox_firstName);
            this.grpBox_addClient.Controls.Add(this.label3);
            this.grpBox_addClient.Controls.Add(this.txtBox_lastName);
            this.grpBox_addClient.Location = new System.Drawing.Point(11, 62);
            this.grpBox_addClient.Name = "grpBox_addClient";
            this.grpBox_addClient.Size = new System.Drawing.Size(170, 136);
            this.grpBox_addClient.TabIndex = 1;
            this.grpBox_addClient.TabStop = false;
            this.grpBox_addClient.Text = "New Client";
            // 
            // chkBox_newClient
            // 
            this.chkBox_newClient.AutoSize = true;
            this.chkBox_newClient.Location = new System.Drawing.Point(12, 102);
            this.chkBox_newClient.Name = "chkBox_newClient";
            this.chkBox_newClient.Size = new System.Drawing.Size(111, 17);
            this.chkBox_newClient.TabIndex = 4;
            this.chkBox_newClient.Text = "Create New Client";
            this.chkBox_newClient.UseVisualStyleBackColor = true;
            // 
            // grpBox_existingClient
            // 
            this.grpBox_existingClient.Controls.Add(this.cmbBox_existingClients);
            this.grpBox_existingClient.Location = new System.Drawing.Point(11, 6);
            this.grpBox_existingClient.Name = "grpBox_existingClient";
            this.grpBox_existingClient.Size = new System.Drawing.Size(170, 50);
            this.grpBox_existingClient.TabIndex = 0;
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

        private System.Windows.Forms.ComboBox cmbBox_existingClients;
        private System.Windows.Forms.TextBox txtBox_firstName;
        private System.Windows.Forms.TextBox txtBox_lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ClientReady;
        private System.Windows.Forms.GroupBox grpBox_addClient;
        private System.Windows.Forms.GroupBox grpBox_existingClient;
        private System.Windows.Forms.CheckBox chkBox_newClient;
    }
}
