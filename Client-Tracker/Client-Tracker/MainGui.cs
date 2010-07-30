using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Client_Tracker.Encryption;
using System.Text.RegularExpressions;
using License;

namespace Client_Tracker
{
    public partial class MainGui : Form
    {
        string publicKey = "<RSAKeyValue><Modulus>ph9nU2+VKhjOLc3aW0Rg4UgIQGAiSt6+75l8MtsjFxs2uBs0ApIG9ihGG8RW8HvY4I5Ll4+k9Pe1HtQJ3OBVFMTxYo/FgS3x1V6dKRJ6UXgfDWPJVr0fE2bOdDa5F6oGv8JEQE6DCWV5jFHX57fSzqHA6UovJrui6FB9KtybCDk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        License.LicenseClass license;
        /// <summary>
        /// Holds the master list of clients that the program has loaded
        /// </summary>
        private List<Client> ClientList = new List<Client>();

        public List<Client> GetClientList()
        {
            return ClientList;
        }

        /// <summary>
        /// Adds a Client to master list
        /// </summary>
        /// <param name="cl">Client to add</param>
        public void AddClient(Client cl)
        {
            ClientList.Add(cl);
        }

        /// <summary>
        /// Removes a client from the master list
        /// </summary>
        /// <param name="cl">Client to remove</param>
        public void RemoveClient(Client cl)
        {
            ClientList.Remove(cl);
        }

        public MainGui()
        {
            LoadData();// read client info from xml
            InitializeComponent();
            getClient1.SetCmbBoxBindingSrc(GetClientList());
            getClient1.RebindCmbBoxDataSrc();

            // subsribe to holdButton so we can move form to hold area
            clientActions1.btn_pauseAndHold.Click += new EventHandler(btn_pauseAndHold_Click);

            // subscribe to client ready so we can load a client into the client actions
            getClient1.ClientReady += new EventHandler(getClient1_ClientReady);

            // subscribe to activate client so we can reload a client.
            holdArea1.ActivateClient += new EventHandler(holdArea1_ActivateClient);

            CheckLicense();

        }

        private void CheckLicense()
        {
            string licenseFile = string.Empty;
            using (StreamReader sr = new StreamReader("cmlic"))
            {
                licenseFile = sr.ReadToEnd();
            }

            string passPhrase = "@0aWYM#%";        // can be any string
            string saltValue = "k%om*X8S";        // can be any string
            string hashAlgorithm = "SHA1";             // can be "MD5"
            int passwordIterations = 2;                  // can be any number
            string initVector = "ObIM5&0C%$R9IwLV"; // must be 16 bytes
            int keySize = 256;                // can be 192 or 128

            string decryptedLicenseFile = SymetricEncryption.Decrypt(licenseFile,
                                                    passPhrase,
                                                    saltValue,
                                                    hashAlgorithm,
                                                    passwordIterations,
                                                    initVector,
                                                    keySize);
            string[] lines = Regex.Split(decryptedLicenseFile, "\r\n");
            string sig = lines[0];
            string licenseFileXML = lines[1];

            bool isLicenseValid = Encryption.DigitalSigning.VerifySignature(licenseFileXML, sig, publicKey);

            if (isLicenseValid)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.LoadXml(licenseFileXML);
                license = (LicenseClass)Serialization.Serializer.Deserialize(xDoc, typeof(LicenseClass));
                ClientTrackerUser user = new ClientTrackerUser(license.FirstName, license.LastName);
                clientActions1.SetUser(user);
                lbl_licensedTo.Text = "Licensed to: " + license.FirstName + " " + license.LastName;
            }
            else
            {
                MessageBox.Show("Unable to validate license if you purchased this software and lost your license please contact" +
                    "the developer at andy@chiefmarley.com for a new one");
                Application.Exit();
            }
        }

        /// <summary>
        /// re-activate a client from the hold area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void holdArea1_ActivateClient(object sender, EventArgs e)
        {
            WorkOnHold w = (WorkOnHold)sender;

            // move to active area
            clientActions1.LoadHoldData(w.GetHoldData());
            clientActions1.Invalidate();

            // remove from hold area
            holdArea1.RemoveWorkOnHold(w);
            DisableClientSelection();
          
        }


        /// <summary>
        /// Set client from getClient Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void getClient1_ClientReady(object sender, EventArgs e)
        {
            Client c = (Client)sender;
            if (c == null)
            {
                MessageBox.Show("Please select a client");
                // let user select another client
                EnableClientSelection();
                return;
            }

            // if full name of client matches another full name, and a new client was supposed to be created
            if (GetClientList().Any(x => x.FullName.ToLower() == c.FullName.ToLower()) && getClient1.NewClientChecked)
            {
                // if client is already in list & we checked new client,
                Client duplicate = new Client(c.FirstName + "X",c.LastName);

                // warning message for duplicate name entry
                string warnMsg = c.FullName + " is already listed as a client\r\nIf you proceed, " 
                    + duplicate.FullName + " will be used instead";

                var dr = MessageBox.Show(warnMsg, "Client Already In List", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    // if user wants to add another client with same name(X appended to first name)
                    c = duplicate;
                    AddClient(c);
                }
                else
                {
                    // let user select another client
                    EnableClientSelection();
                    return;
                }
            }
            else if (getClient1.NewClientChecked)
            {
                // else if new client checked add them to the list
                ClientList.Add(c);
            }
            
            // set client that we want to work on
            clientActions1.SetClient(c);

            DisableClientSelection();
            getClient1.RebindCmbBoxDataSrc();
            
            
        }

        /// <summary>
        /// Disable controls where you can load a client
        /// </summary>
        void DisableClientSelection()
        {
            getClient1.Enabled = false;
            holdArea1.Enabled = false;
        }

        /// <summary>
        /// Enable controls where you can load a client
        /// </summary>
        public void EnableClientSelection()
        {
            getClient1.Enabled = true;
            holdArea1.Enabled = true;
        }

        /// <summary>
        /// Method that fires when user clicks pause and hold, using it to pause timer 
        /// an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_pauseAndHold_Click(object sender, EventArgs e)
        {
            // stop timer
            clientActions1.StopTimer();

            // add current clientActions to hold area
            holdArea1.AddClientActions(clientActions1);

            // reset client actions area
            clientActions1.ResetControlData();

            // allow selection of a new client
            EnableClientSelection();

        }

        // Loads data from XML files
        private void LoadData()
        {
            LoadClients();
        }

        /// <summary>
        /// load clients from xml file
        /// </summary>
        private void LoadClients()
        {
            ClientList = new List<Client>();
            FileInfo fi = new FileInfo("ClientTrackerData.xml");
            try
            {
                using (TextReader tr = new StreamReader(fi.Name))
                {
                    string xml = tr.ReadToEnd();

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.LoadXml(xml);
                    var cl = (ClientTrackerData)Serialization.Serializer.Deserialize(xDoc, typeof(ClientTrackerData));
                    foreach (ClientData d in cl.ClData)
                    {
                        Client c = new Client(d);
                        AddClient(c);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Unable to find Client Tracker Data file\r\nIf this is the first " +
                    "time you have ran this a new file will be created\r\nIf this is not your first time" +
                    " running Client Tracker, restore a backup");
                return;
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }


        private void setUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetUserName getName = new GetUserName();
            getName.btn_registerUser.Click += new EventHandler(btn_registerUser_Click);
            getName.ShowDialog();
        }

        void btn_registerUser_Click(object sender, EventArgs e)
        {
            GetUserName getUserForm = (GetUserName)((Control)sender).Parent;
            clientActions1.SetUser(getUserForm.GetUser());
            getUserForm.Dispose();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTrackerData objToSerialize = new ClientTrackerData(GetClientList());

            // serialize clientList into XmlDocument
            XmlDocument xDoc = Serialization.Serializer.Serialize(objToSerialize);

            FileInfo fi = new FileInfo("ClientTrackerData.xml");
            using (XmlTextWriter xtw = new XmlTextWriter(fi.Name, Encoding.ASCII))
            {

                xtw.Formatting = Formatting.Indented;
                xtw.Indentation = 1;
                xtw.IndentChar = '\x09';

                // save to fi
                xDoc.Save(xtw);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadClients();
            getClient1.RebindCmbBoxDataSrc();
        }
    }
}
