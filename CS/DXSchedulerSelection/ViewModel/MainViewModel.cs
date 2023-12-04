using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace DXSchedulerSelection {
    public class MainViewModel : ViewModelBase {
        public MainViewModel() {
            SportChannelsData data = new SportChannelsData(3);
            SportEvents = data.Events;
            SportChannels = data.Channels;
            SportGroups = data.Groups;
        }
        public ObservableCollection<SportEvent> SportEvents { get; }
        public ObservableCollection<SportChannel> SportChannels { get; }
        public ObservableCollection<SportGroup> SportGroups { get; }
    }
}
