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
        List<Client> Clients; 
        public GetClient(List<Client> clients)
        {
            Clients = clients;
            InitializeComponent();
            BindingSource bs = new BindingSource(Clients,null);
            comboBox1.DataSource = bs.DataSource;

            comboBox1.DisplayMember = "FullName";
            
            
        }
    }
}
