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

            // subscribe to client ready so we can load a client into the client actions
            getClient1.ClientReady += new EventHandler(getClient1_ClientReady);

            // subscribe to activate client so we can reload a client.
            holdArea1.ActivateClient += new EventHandler(holdArea1_ActivateClient);
        }


        /// <summary>
        /// re-activate a client from the hold area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void holdArea1_ActivateClient(object sender, EventArgs e)
        {
            WorkOnHold w = (WorkOnHold)sender;

            // move to active area
            clientActions1.LoadHoldData(w.GetHoldData());
            clientActions1.Invalidate();

            // remove from hold area
            holdArea1.RemoveWorkOnHold(w);
            DisableClientSelection();
          
        }


        /// <summary>
        /// Set client from getClient Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void getClient1_ClientReady(object sender, EventArgs e)
        {
            Client c = (Client)sender;
            clientActions1.SetClient(c);
            DisableClientSelection();
        }

        /// <summary>
        /// Disable controls where you can load a client
        /// </summary>
        void DisableClientSelection()
        {
            getClient1.Enabled = false;
            holdArea1.Enabled = false;
        }

        /// <summary>
        /// Enable controls where you can load a client
        /// </summary>
        void EnableClientSelection()
        {
            getClient1.Enabled = true;
            holdArea1.Enabled = true;
        }

        /// <summary>
        /// Method that fires when user clicks pause and hold, using it to pause timer 
        /// an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_pauseAndHold_Click(object sender, EventArgs e)
        {
            // stop timer
            clientActions1.StopTimer();

            // add current clientActions to hold area
            holdArea1.AddClientActions(clientActions1);

            // reset client actions area
            clientActions1.ResetControlData();

            // allow selection of a new client
            EnableClientSelection();

        }

        // Loads data from XML files
        private void LoadData()
        {
            LoadClients();
        }

        /// <summary>
        /// load clients from xml file
        /// </summary>
        private void LoadClients()
        {
            // loading fake client for testing
            Client testClient = new Client("bob", "Wilson");
            ClientList.Add(testClient);
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void getClient1_Load(object sender, EventArgs e)
        {

        }

    }
}
