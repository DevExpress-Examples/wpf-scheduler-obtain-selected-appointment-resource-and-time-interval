using DevExpress.Xpf.Core;
using DevExpress.Xpf.Scheduling;
using System.Windows;

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

        private void schedulerControl_DependencyPropertyChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            SchedulerControl scheduler = sender as SchedulerControl;
            if (e.Property == SchedulerControl.SelectedIntervalProperty)
            {
                OutputBox.AppendText(string.Format("SelectedInterval is changed. New value is {0} \r\n", e.NewValue));
                OutputBox.ScrollToEnd();
            }
            if (e.Property == SchedulerControl.SelectedResourceProperty)
            {
                OutputBox.AppendText(string.Format("SelectedResource is changed. New value is {0} \r\n", ((ResourceItem)e.NewValue).Caption));
                OutputBox.ScrollToEnd();
            }
        }
    }
}
