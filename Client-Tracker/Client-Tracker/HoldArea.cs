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
            
            WorkOnHold work = new WorkOnHold(ca);

            // add to list
            WorkOnHoldLst.Add(work);

            // add to Controls
            this.Controls.Add(work);

            int i = WorkOnHoldLst.IndexOf(work);
            work.btn_activate.Click += new EventHandler(btn_activate_Click);
            work.Location = new Point(0, i * work.Height);
            work.Visible = true;
            work.Show();
            work.Refresh();
        }

        private void OrganizeHoldArea()
        {
            int i = Controls.Count;
            foreach (Control c in Controls)
            {
                int yLoc = Controls.IndexOf(c);
                c.Location = new Point(0, yLoc * c.Height);
            }
        }
        public void RemoveWorkOnHold(WorkOnHold w)
        {
            // remove from list
            WorkOnHoldLst.Remove(w);

            // remove from Controls
            Controls.Remove(w);

            //reorganize control area
            OrganizeHoldArea();

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
