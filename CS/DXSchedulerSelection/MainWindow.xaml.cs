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
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Scheduling;
using DevExpress.Mvvm;
using DevExpress.XtraScheduler;

namespace DXSchedulerSelection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void schedulerControl_AppointmentWindowShowing(object sender, AppointmentWindowShowingEventArgs e)
        {            
            CheckSelectedAppointment();
            e.Cancel = CheckSelectedInterval();
        }


        private bool CheckSelectedInterval()
        {
            #region #SelectedInterval
            //Retrieve the selected interval:
            DateTimeRange selectedInterval = schedulerControl.SelectedInterval;

            //Check whether the target interval starts after October 1st
            //and belongs to the "TV 5" resource:
            if (selectedInterval.Start.Date > new DateTime(2017, 10, 1) & schedulerControl.SelectedResource == schedulerControl.ResourceItems[4])
            {
                //If true, notify the user about the changes in the TV program:
                MessageBox.Show("Starting from October, the TV 5 stops broadcasting in your country. Sorry for the inconvenience");
                return true;
            }
            #endregion #SelectedInterval
            return false;
        }


        private void CheckSelectedAppointment()
        {
            if (schedulerControl.SelectedAppointments.Count > 0)
            {
                #region #SelectedAppointment
                //Retrieve the selected time interval: 
                AppointmentItem appointment = schedulerControl.SelectedAppointments[0];

                //Check whether the event time intersects with the news block broadcast on the "Sport TV 2" channel: 
                if (appointment.Start.Hour == 19 & appointment.ResourceId.ToString() == "1")
                {
                    //If true, notify the user about the news block intersection:
                    MessageBox.Show("The event broadcasting continues after the news block");
                }
                #endregion #SelectedAppointment
            }
        }

    }
}
