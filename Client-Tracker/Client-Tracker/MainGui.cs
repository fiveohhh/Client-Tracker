using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client_Tracker
{
    public partial class MainGui : Form
    {
        public List<Client> ClientList = new List<Client>();
        public MainGui()
        {
            LoadData();// read client info from xml
            InitializeComponent();
            getClient1.SetClientList(ClientList);

            // subsribe to holdButton so we can move form to hold area
            clientActions1.btn_pauseAndHold.Click += new EventHandler(btn_pauseAndHold_Click);
            getClient1.ClientReady += new EventHandler(getClient1_ClientReady);

            holdArea1.ActivateClient += new EventHandler(holdArea1_ActivateClient);
        }

        void holdArea1_ActivateClient(object sender, EventArgs e)
        {
            WorkOnHold w = (WorkOnHold)sender;

            // move to active area
            clientActions1.LoadHoldData(w.GetHoldData());
            clientActions1.Invalidate();

            // remove from hold area
            holdArea1.Controls.Remove(w);

 

            // move from hold area to active area
            //throw new NotImplementedException();
        }

        void getClient1_ClientReady(object sender, EventArgs e)
        {
            Client c = (Client)sender;
            
            clientActions1.SetClient(c);
        }

        void btn_pauseAndHold_Click(object sender, EventArgs e)
        {
            
            clientActions1.StopTimer();

            // add current clientActions to hold area
            holdArea1.AddClientActions(clientActions1);

            clientActions1.ResetControlData();
            //clientActions1 = new ClientActions();

            clientActions1.Enabled = false;
        }

        // Loads data from XML files
        private void LoadData()
        {
          //  LoadWorkEntries();
            LoadClients();
          //  throw new NotImplementedException();
        }

        private void LoadWorkEntries()
        {
            // load into single list
            throw new NotImplementedException();
        }

        private void LoadClients()
        {
            // loading fake client for testing
            Client testClient = new Client("bob", "Wilson");
            ClientList.Add(testClient);
            

            // pull from work entries from list for each individual client
            // do something with orphaned entries?
           // throw new NotImplementedException();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clientActions1.Enabled)
            {
                clientActions1.Enabled = false;
            }
            else
            {
                clientActions1.Enabled = true;
            }
        }

   

     
    }
}
