//Using Class Library
using AssistanceClasses;

//Using System
using System;
using System.Windows.Input;

namespace FSMain
{
    public class FSMainViewModel : BaseViewModel, IPageViewModel
    {
        private ICommand _goToFSMain;

        public ICommand GoToFSMain
        {
            get
            {
                return _goToFSMain ?? (_goToFSMain = new RelayCommand(x =>
                {
                    Mediator.Notify("GoToFSMain", "");
                }));
            }
        }
    }
}
