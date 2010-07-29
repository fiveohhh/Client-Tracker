using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client_Tracker
{
    public partial class GetClient : UserControl
    {
        public event EventHandler ClientReady;

        public GetClient()
        {
            InitializeComponent();
        }

        public void SetClientList(List<Client> clients)
        {
            BindingSource bs = new BindingSource(clients, null);
            cmbBox_existingClients.DataSource = bs.DataSource;

            cmbBox_existingClients.DisplayMember = "FullName";
            this.Invalidate();
        }

        private void btn_ClientReady_Click(object sender, EventArgs e)
        {
            Client desiredClient;
            if (chkBox_newClient.Checked)
            {
                // if new client box is checked
                desiredClient = new Client(txtBox_firstName.Text, txtBox_lastName.Text);
                txtBox_firstName.Text = string.Empty;
                txtBox_lastName.Text = string.Empty;

            }
            else
            {
                // else use client in combobox
                desiredClient = (Client)cmbBox_existingClients.SelectedValue;
                
            }

            // need to tell main gui we have a client ready to load
            if (ClientReady != null)
            {
                ClientReady(desiredClient,null);
            }
            
        }
    }
}
