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
        HoldData data;
        public WorkOnHold(ClientActions actions)
        {
            data = new HoldData(actions);
            InitializeComponent();
            lbl_name.Text = data.Client.FullName;
        }

        public HoldData GetHoldData()
        {
            return data;
        }
    }
}
