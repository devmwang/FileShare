// Using Class Libraries
using AssistanceClasses;
using FSMain;

// Using System
using System.Collections.Generic;
using System.Linq;



namespace FileShare
{
    public class ApplicationViewModel : BaseViewModel
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
        private void OnGoFSMain(object obj)
        {
            ChangeViewModel(PageViewModels[0]);
        }

        public ApplicationViewModel()
        {
            // Add available pages and set page
            PageViewModels.Add(new FSMainViewModel());

            // Set Startup ViewModel
            CurrentPageViewModel = PageViewModels[0];

            // Mediator Receiving
            Mediator.Subscribe("GoToFSMain", OnGoFSMain);
        }
    }
}
