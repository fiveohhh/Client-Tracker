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
    public partial class HoldArea : UserControl
    {
        List<WorkOnHold> WorkOnHoldLst;

        public event EventHandler ActivateClient;

        public HoldArea()
        {
            WorkOnHoldLst = new List<WorkOnHold>();
            InitializeComponent();
        }

        public void AddClientActions(ClientActions ca)
        {
            int i = WorkOnHoldLst.Count;
            WorkOnHold work = new WorkOnHold(ca);
            WorkOnHoldLst.Add(work);
            this.Controls.Add(work);
            work.btn_activate.Click += new EventHandler(btn_activate_Click);
            work.Location = new Point(0, i * work.Height);
            work.Visible = true;
            work.Show();
            work.Refresh();
        }

        void btn_activate_Click(object sender, EventArgs e)
        {
            // get work on hold from parent control of button.
            WorkOnHold w = (WorkOnHold)(((Control)sender).Parent);
            if (ActivateClient != null)
            {
                // pass back Client data
                ActivateClient(w, null);
            }
        }



       
    }
}
