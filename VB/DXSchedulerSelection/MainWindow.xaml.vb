Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Scheduling
Imports DevExpress.Mvvm
Imports DevExpress.XtraScheduler

Namespace DXSchedulerSelection
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub schedulerControl_AppointmentWindowShowing(ByVal sender As Object, ByVal e As AppointmentWindowShowingEventArgs)
            CheckSelectedAppointment()
            e.Cancel = CheckSelectedInterval()
        End Sub


        Private Function CheckSelectedInterval() As Boolean
'            #Region "#SelectedInterval"
            'Retrieve the selected interval:
            Dim selectedInterval As DateTimeRange = schedulerControl.SelectedInterval

            'Check whether the target interval starts after October 1st
            'and belongs to the "TV 5" resource:
            If selectedInterval.Start.Date > New Date(2017, 10, 1) And schedulerControl.SelectedResource Is schedulerControl.ResourceItems(4) Then
                'If true, notify the user about the changes in the TV program:
                MessageBox.Show("Starting from October, the TV 5 stops broadcasting in your country. Sorry for the inconvenience")
                Return True
            End If
            '            #End Region ' #SelectedInterval
            Return False
        End Function


        Private Sub CheckSelectedAppointment()
            If schedulerControl.SelectedAppointments.Count > 0 Then
'                #Region "#SelectedAppointment"
                'Retrieve the selected time interval: 
                Dim appointment As AppointmentItem = schedulerControl.SelectedAppointments(0)

                'Check whether the event time intersects with the news block broadcast on the "Sport TV 2" channel: 
                If appointment.Start.Hour = 19 And appointment.ResourceId.ToString() = "1" Then
                    'If true, notify the user about the news block intersection:
                    MessageBox.Show("The event broadcasting continues after the news block")
                End If
'                #End Region ' #SelectedAppointment
            End If
        End Sub

    End Class
End Namespace
