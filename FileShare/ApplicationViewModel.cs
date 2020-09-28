// Using Class Libraries
using AssistanceClasses;
using SendPanel;

// Using System
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace FileShare
{
    public class ApplicationViewModel : BaseViewModel, IPageViewModel
    {
        // View And VM Switching Logic
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                _currentPageViewModel = value;
                OnPropertyChanged("CurrentPageViewModel");
            }
        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        // ViewModel Switching
        private void OnGoSendPanel(object obj)
        {
            ChangeViewModel(PageViewModels[0]);
        }

        public ApplicationViewModel()
        {
            // Add available pages and set page
            PageViewModels.Add(new SendPanelViewModel());

            // Set Startup ViewModel
            CurrentPageViewModel = PageViewModels[0];

            // Mediator Receiving
            Mediator.Subscribe("GoToSendPanel", OnGoSendPanel);
        }
    }
}
