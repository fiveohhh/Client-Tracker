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
        ClientTrackerUser User;
        DateTime StartTime;
        Client Client;
        public ClientActions()
        {
            InitializeComponent();
            BindTypeOfWorkToComboBox();
            digitalDisplay1.CountDown = false;
            Enabled = false;
        }

        public void SetUser(ClientTrackerUser user)
        {
            User = user;
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
            ((MainGui)((Control)((Control)this.Parent).Parent).Parent).DisableViewClient();
            Enabled = false;
            EnableClientSelection();
            Client = null;
            digitalDisplay1.Stop();
            digitalDisplay1.Reset();
            cmbBox_typeOfWorkDone.SelectedIndex = 0;

            lbl_clientName.Text = string.Empty;
            txtBox_notes.Text = string.Empty;
        }

        void EnableClientSelection()
        {
            ((MainGui)((Control)((Control)this.Parent).Parent).Parent).EnableClientSelection();
        }

        public void LoadHoldData(HoldData holdData)
        {
            ResetControlData();

            TimeSpan zero = new TimeSpan(0, 0, 0);
            if (GetElapsedTime() != zero)
            {
                // if there is a client loaded with the timer started already
                // We need to decide if we want to throw it away.  Probably will
                // pop up verifying that user wants to throw current away with old one

                // let's just make sure both the hold area and the select Client area are disabled unless the client area is empty
                throw new Exception("Need to have a clear client actions before we load data");
            }
            else
            {
                Client = holdData.Client;
                lbl_clientName.Text = Client.FullName;
                cmbBox_typeOfWorkDone.SelectedItem = holdData.WorkType;
                txtBox_notes.Text = holdData.Notes;
                StartTime = holdData.StartTime;
                digitalDisplay1.SetElapasedTime(holdData.ElapsedTime);
                this.Enabled = true;
                this.Invalidate();
            }
        }
        
        /// <summary>
        /// Get all the data we need, to process a new entry 
        /// </summary>
        /// <returns></returns>
        public HoldData GetHoldData()
        {
            return new HoldData(this);
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
            lbl_clientName.Text = Client.FullName;
            
            // start timer as soon as client loads
            digitalDisplay1.Start();
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

        private void btn_submitEntry_Click(object sender, EventArgs e)
        {
            if (this.txtBox_notes.Text == "")
            {
                var result = MessageBox.Show("Are you sure you want to submit this entry with no notes?\r\nPress OK to submit as empty, or press cancel to add notes",
                    "Notes field is empty", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Client.AddWorkEntry(new WorkEntry(StartTime, GetElapsedTime(), txtBox_notes.Text, User, (TypesOfWork)cmbBox_typeOfWorkDone.SelectedValue), User);
                    ResetControlData();
                }
                else
                {
                    // do nothing
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to remove this Client?\r\nAny work recorded will not be saved.", 
                                "Are You Sure?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                //get rid of work
                this.ResetControlData();
            }
            else
            {
                // do nothing and pretend we never clicked it
            }
        }
    }
}
