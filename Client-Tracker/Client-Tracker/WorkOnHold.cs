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
    public partial class WorkOnHold : UserControl
    {
        public WorkOnHold(ClientActions actions)
        {
            InitializeComponent();
            digitalDisplay1 = actions.GetDisplay();
            lbl_name.Text = actions.GetClient().FullName;
        }
    }
}
