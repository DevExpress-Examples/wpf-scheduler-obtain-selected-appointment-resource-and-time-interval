#Region "#viewmodel"
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.ObjectModel

Namespace DXSchedulerSelection
    <POCOViewModel> _
    Public Class MainViewModel
        Private ReadOnly data As New SportChannelsData(3)
        Protected Sub New()
        End Sub
        Public Overridable ReadOnly Property SportEvents() As ObservableCollection(Of SportEvent)
            Get
                Return data.Events
            End Get
        End Property
        Public Overridable ReadOnly Property SportChannels() As ObservableCollection(Of SportChannel)
            Get
                Return data.Channels
            End Get
        End Property
        Public Overridable ReadOnly Property SportGroups() As ObservableCollection(Of SportGroup)
            Get
                Return data.Groups
            End Get
        End Property
    End Class
End Namespace
#End Region ' #viewmodel
