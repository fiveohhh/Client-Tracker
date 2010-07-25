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

        DateTime StartTime;
        Client Client;
        public ClientActions()
        {
            InitializeComponent();
            BindTypeOfWorkToComboBox();
            digitalDisplay1.CountDown = false;
            Enabled = false;
        }

        public void StopTimer()
        {
            digitalDisplay1.Stop();
        }

        public TimeSpan GetElapsedTime()
        {
            TimeSpan ts = new TimeSpan(int.Parse(digitalDisplay1.Hours), int.Parse(digitalDisplay1.Minutes), int.Parse(digitalDisplay1.Seconds));
            return ts;
        }

        public DateTime GetStartTime()
        {
            return StartTime;
        }

        public string GetNotes()
        {
            return txtBox_notes.Text;
        }

        public TypesOfWork GetTypeOfWork()
        {
            return (TypesOfWork)cmbBox_typeOfWorkDone.SelectedValue;
        }

        /// <summary>
        /// Resets control back to virgin state
        /// </summary>
        public void ResetControlData()
        {
            Client = null;
            digitalDisplay1.Stop();
            digitalDisplay1.Reset();

            lbl_clientName.Text = string.Empty;
            txtBox_notes.Text = string.Empty;
        }

        /// <summary>
        /// Set the client for this form
        /// </summary>
        /// <param name="client">client to work on</param>
        public void SetClient(Client client)
        {
            Client = client;
            Enabled = true;
            StartTime = DateTime.Now;
            lbl_clientName.Text = Client.LastName;
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

      

       

    }
}
