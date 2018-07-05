#region #viewmodel
using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;

namespace DXSchedulerSelection
{
    [POCOViewModel]
    public class MainViewModel
    {
        readonly SportChannelsData data = new SportChannelsData(3);
        protected MainViewModel(){
        }
        public virtual ObservableCollection<SportEvent> SportEvents { get { return data.Events; } }
        public virtual ObservableCollection<SportChannel> SportChannels { get { return data.Channels; } }
        public virtual ObservableCollection<SportGroup> SportGroups { get { return data.Groups; } }
    }
}
#endregion #viewmodel
