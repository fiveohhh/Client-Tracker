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
        public ViewWorkEntry()
        {
            InitializeComponent();
        }

        public void SetWorkEntry(WorkEntry entry)
        {
            lbl_ClientTrackerUser.Content = entry.User.FirstName + " " + entry.User.LastName;
            lbl_DateTime.Content = entry.StartTime.ToString("g");
            lbl_WorkType.Content = entry.TypeOfWorkDone.ToString();
            lbl_Duration.Content = Math.Round(entry.TimeWorked.TotalMinutes, 2).ToString() + " minutes";

            txtBox_Notes.Text = entry.Notes;
        }
    }
}
