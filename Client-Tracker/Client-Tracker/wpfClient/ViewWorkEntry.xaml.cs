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

namespace Client_Tracker.wpfClient
{
    /// <summary>
    /// Interaction logic for ViewWorkEntry.xaml
    /// </summary>
    public partial class ViewWorkEntry : UserControl
    {
        WorkEntry CurrentEntry;

        public ViewWorkEntry()
        {
            InitializeComponent();
            this.txtBox_Notes.IsEnabled = false;
        }

        public void SetWorkEntry(WorkEntry entry)
        {
            CurrentEntry = entry;
            lbl_ClientTrackerUser.Content = entry.User.FirstName + " " + entry.User.LastName;
            lbl_DateTime.Content = entry.StartTime.ToString("g");
            lbl_WorkType.Content = entry.TypeOfWorkDone.ToString();
            lbl_Duration.Content = Math.Round(entry.TimeWorked.TotalMinutes, 2).ToString() + " minutes";

            txtBox_Notes.Text = entry.Notes;
        }

        private void btn_editEntry_Click(object sender, RoutedEventArgs e)
        {
            if (btn_editEntry.Content.ToString() == "Edit")
            {
                btn_editEntry.Content = "Save";
                txtBox_Notes.IsEnabled = true;
            }
            else
            {
                btn_editEntry.Content = "Edit";
                txtBox_Notes.IsEnabled = false;
                CurrentEntry.Notes = txtBox_Notes.Text;
            }
        }
    }
}
