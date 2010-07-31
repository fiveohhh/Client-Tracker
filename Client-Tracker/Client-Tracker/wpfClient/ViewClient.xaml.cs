using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client_Tracker.wpfForms
{
    /// <summary>
    /// Interaction logic for ViewClient.xaml
    /// </summary>
    public partial class ViewClient : UserControl
    {
        public ViewClient()
        {
            InitializeComponent();
        }

        public void SetClient(Client client)
        {
            lbl_ClientName.Content = client.FullName;
            
            cmbBox_workEntries.ItemsSource = client.AllWorkDone;
            cmbBox_workEntries.DisplayMemberPath = "StartTime";
        }

        private void cmbBox_workEntries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewWorkEntry1.SetWorkEntry((WorkEntry)cmbBox_workEntries.SelectedItem);
        }
    } 
}
