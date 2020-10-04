// Using Class Libraries
using AssistanceClasses;
using FileShareData;

// Using System
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;



namespace FileShare
{
    /// <summary>
    /// Interaction logic for ApplicationView.xaml
    /// </summary>
    public partial class ApplicationView : Window
    {
        // Initialize ApplicationView
        public ApplicationView()
        {
            InitializeComponent();
        }

        // Focus on background when clicked
        private void ApplicationWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ApplicationBackground.Focus();
        }

        #region Sidebar Tooltips
        // Mouse Enter Tooltip
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            tt_send.Visibility = Visibility.Visible;
            tt_receive.Visibility = Visibility.Visible;
            tt_settings.Visibility = Visibility.Visible;

        }
        #endregion

        #region Progress Bar
        // Progress Bar Updates
        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            await ProgressBarUpdate();
        }

        private async Task ProgressBarUpdate()
        {
            await Task.Run(() =>
            {
                if (FileShareDataModel.TransferProgress != 100)
                {
                    FileSendReceiveProgress.Dispatcher.Invoke(new Action(() =>
                    {
                        FileSendReceiveProgress.Value = FileShareDataModel.TransferProgress;
                    }));
                }
            });
        }

  //      private void Window_ContentRendered(object sender, EventArgs e)
		//{
  //          FileSendReceiveProgress.Maximum = 500;

		//	BackgroundWorker ProgressBarWorker = new BackgroundWorker();
  //          ProgressBarWorker.WorkerReportsProgress = true;
  //          ProgressBarWorker.DoWork += ProgressBarWorker_DoWork;
  //          ProgressBarWorker.ProgressChanged += ProgressBarWorker_ProgressChanged;

  //          ProgressBarWorker.RunWorkerAsync();
		//}

		//private void ProgressBarWorker_DoWork(object sender, DoWorkEventArgs e)
		//{
		//	for (int i = 0; i < 500; i++)
		//	{
		//		(sender as BackgroundWorker).ReportProgress(i);
		//		Thread.Sleep(50);
		//	}
		//}

  //      private void ProgressBarWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		//{
		//	FileSendReceiveProgress.Value = e.ProgressPercentage;
		//}
        #endregion
    }
}
