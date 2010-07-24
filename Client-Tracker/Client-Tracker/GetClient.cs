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
        public GetClient()
        {
            InitializeComponent();
        }

        public void SetClientList(List<Client> clients)
        {
            BindingSource bs = new BindingSource(clients, null);
            comboBox1.DataSource = bs.DataSource;

            comboBox1.DisplayMember = "FullName";
        }
    }
}
