Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Scheduling
Imports System.Windows

Namespace DXSchedulerSelection

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub schedulerControl_DependencyPropertyChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
            Dim scheduler As SchedulerControl = TryCast(sender, SchedulerControl)
            If e.Property Is SchedulerControl.SelectedIntervalProperty Then
                Me.OutputBox.AppendText(String.Format("SelectedInterval is changed. New value is {0} " & Microsoft.VisualBasic.Constants.vbCrLf, e.NewValue))
                Me.OutputBox.ScrollToEnd()
            End If

            If e.Property Is SchedulerControl.SelectedResourceProperty Then
                Me.OutputBox.AppendText(String.Format("SelectedResource is changed. New value is {0} " & Microsoft.VisualBasic.Constants.vbCrLf, CType(e.NewValue, ResourceItem).Caption))
                Me.OutputBox.ScrollToEnd()
            End If
        End Sub
    End Class
End Namespace
