using Caliburn.Micro;

namespace CaliburnMicroWpfExamples
{
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        private readonly IWindowManager _windowManager;
        private readonly IEventAggregator _eventAggregator;

        public ShellViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            _windowManager = windowManager;
            _eventAggregator = eventAggregator;
        }

        public void WindowManagerExample()
        {
            _windowManager.ShowDialog(new WindowManagerExample.MainViewModel(_windowManager));
        }

        public void EventsExample()
        {
            _windowManager.ShowDialog(new EventsExample.MainViewModel());
        }

        public void MasterDetailExample()
        {
            _windowManager.ShowDialog(new MasterDetailExample.MainViewModel());
        }

        public void EventAggregatorExample()
        {
            _windowManager.ShowDialog(new EventAggregatorExample.MainViewModel(_windowManager, _eventAggregator));
        }

        public void ConductorExample()
        {
            _windowManager.ShowDialog(new ConductorExample.MainViewModel());
        }

        public void OneActiveExample()
        {
            _windowManager.ShowDialog(new ConductorExample.Collections.OneActive.MainViewModel());
        }

        public void AllActiveExample()
        {
            _windowManager.ShowDialog(new ConductorExample.Collections.AllActive.MainViewModel());
        }

        public void CoroutinesExample()
        {
            _windowManager.ShowDialog(new CoroutinesExample.MainViewModel());
        }
    }
}