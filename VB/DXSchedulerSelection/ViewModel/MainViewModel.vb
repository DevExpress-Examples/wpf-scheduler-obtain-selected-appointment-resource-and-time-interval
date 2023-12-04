Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace DXSchedulerSelection

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Sub New()
            Dim data As SportChannelsData = New SportChannelsData(3)
            SportEvents = data.Events
            SportChannels = data.Channels
            SportGroups = data.Groups
        End Sub

        Public ReadOnly Property SportEvents As ObservableCollection(Of SportEvent)

        Public ReadOnly Property SportChannels As ObservableCollection(Of SportChannel)

        Public ReadOnly Property SportGroups As ObservableCollection(Of SportGroup)
    End Class
End Namespace
