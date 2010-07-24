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
            work.Location = new Point(0, i * work.Height);
            work.Show();
            
            
        }

       
    }
}
