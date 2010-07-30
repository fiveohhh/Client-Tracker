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

        BindingSource bs;

        public bool NewClientChecked
        {
            get
            {
                return chkBox_newClient.Checked;
            }
        }

        public GetClient()
        {
            InitializeComponent();
           
        }

        void bs_AddingNew(object sender, AddingNewEventArgs e)
        {
            // check if client full name already exists
            if (((List<Client>)(bs.DataSource)).
                Any(x => x.FullName == ((Client)(e.NewObject)).FullName))
            {
            }
        }

        public void SetCmbBoxBindingSrc(List<Client> clients)
        {
            bs = new BindingSource(clients, null);
            bs.AddingNew += new AddingNewEventHandler(bs_AddingNew);
            //bs.
            cmbBox_existingClients.DisplayMember = "FullName";
        }

        public void RebindCmbBoxDataSrc()
        {
            // rebind data
            cmbBox_existingClients.DataSource = null;
            
            cmbBox_existingClients.DataSource = bs.DataSource;
            cmbBox_existingClients.DisplayMember = "FullName";
            this.Invalidate(true);
        }

        private void btn_ClientReady_Click(object sender, EventArgs e)
        {
            Client desiredClient;
            if (chkBox_newClient.Checked)
            {
                // if new client box is checked add client whilst removing whiteSpace
                desiredClient = new Client(
                    txtBox_firstName.Text.Trim().ToUpperFirstLetter(), 
                    txtBox_lastName.Text.Trim().ToUpperFirstLetter());

                // clear text boxes
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

    
        public static class StringExtension
        {
            // string extension method ToUpperFirstLetter
            public static string ToUpperFirstLetter(this string source)
            {
                if (string.IsNullOrEmpty(source))
                    return string.Empty;
                // convert to char array of the string
                char[] letters = source.ToCharArray();
                // upper case the first char
                letters[0] = char.ToUpper(letters[0]);
                // return the array made of the new char array
                return new string(letters);
            }
        }
    
}
