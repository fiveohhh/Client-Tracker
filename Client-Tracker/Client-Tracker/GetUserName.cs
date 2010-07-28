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
    public partial class GetUserName : Form
    {
        public GetUserName()
        {
            InitializeComponent();
        }

        public ClientTrackerUser GetUser()
        {
            return new ClientTrackerUser(txtBox_firstName.Text, txtBox_lastName.Text);
        }
    }
}
