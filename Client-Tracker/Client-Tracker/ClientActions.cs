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


        Client Client;
        public ClientActions()
        {
            InitializeComponent();
            BindTypeOfWorkToComboBox();
            digitalDisplay1.CountDown = false;
            Enabled = false;
        }

        /// <summary>
        /// Set the client for this form
        /// </summary>
        /// <param name="client">client to work on</param>
        public void SetClient(Client client)
        {
            Client = client;
            Enabled = true;
        }

        /// <summary>
        /// Get Client that this control is working with
        /// </summary>
        /// <returns></returns>
        public Client GetClient()
        {
            return Client;
        }

        public DigitalClock.DigitalDisplay GetDisplay()
        {
            return this.digitalDisplay1;
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

        private void btn_pauseAndHold_Click(object sender, EventArgs e)
        {

        }

       

    }
}
