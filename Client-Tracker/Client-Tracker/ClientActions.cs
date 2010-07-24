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
    public partial class ClientActions : UserControl
    {
        public ClientActions()
        {
            InitializeComponent();
            BindTypeOfWorkToComboBox();
            digitalDisplay1.CountDown = false;
            
        }


        private void BindTypeOfWorkToComboBox()
        {
            cmbBox_typeOfWorkDone.DataSource = System.Enum.GetValues(typeof(TypesOfWork));
        }

        private void btn_StartTime_Click(object sender, EventArgs e)
        {
            digitalDisplay1.Start();
        }

        private void btn_stopTime_Click(object sender, EventArgs e)
        {
            digitalDisplay1.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            digitalDisplay1.Reset();
        }
    }
}
