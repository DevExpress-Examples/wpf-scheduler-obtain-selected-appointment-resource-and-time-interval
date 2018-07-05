Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Scheduling
Imports System.Windows

Namespace DXSchedulerSelection
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub schedulerControl_DependencyPropertyChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
            Dim scheduler As SchedulerControl = TryCast(sender, SchedulerControl)
            If e.Property Is SchedulerControl.SelectedIntervalProperty Then
                OutputBox.AppendText(String.Format("SelectedInterval is changed. New value is {0} " & ControlChars.CrLf, e.NewValue))
                OutputBox.ScrollToEnd()
            End If
            If e.Property Is SchedulerControl.SelectedResourceProperty Then
                OutputBox.AppendText(String.Format("SelectedResource is changed. New value is {0} " & ControlChars.CrLf, DirectCast(e.NewValue, ResourceItem).Caption))
                OutputBox.ScrollToEnd()
            End If
        End Sub
    End Class
End Namespace
