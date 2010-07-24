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
            LoadData();
            InitializeComponent();
            
        }

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
    }
}
