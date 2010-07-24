﻿using System;
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
        }

        private void btn_ClientReady_Click(object sender, EventArgs e)
        {
            Client desiredClient;
            if (chkBox_newClient.Checked)
            {
                // if new client box is checked
                desiredClient = new Client(txtBox_firstName.Text, txtBox_lastName.Text);

            }
            else
            {
                // else use client in combobox
                desiredClient = (Client)cmbBox_existingClients.SelectedValue;
                
            }


            if (ClientReady != null)
            {
                ClientReady(desiredClient,null);
            }
            // need to tell main gui we have a client ready to load
        }
    }
}
