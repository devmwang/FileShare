// Using System
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Input;

// Using Win32
using Microsoft.Win32;

namespace FileShare
{
    /// <summary>
    /// Interaction logic for ApplicationView.xaml
    /// </summary>
    public partial class ApplicationView : Window
    {
        public ApplicationView()
        {
            InitializeComponent();
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
        // Progress Bar
        private void Window_ContentRendered(object sender, EventArgs e)
		{
			BackgroundWorker worker = new BackgroundWorker();
			worker.WorkerReportsProgress = true;
			worker.DoWork += worker_DoWork;
			worker.ProgressChanged += worker_ProgressChanged;

			worker.RunWorkerAsync();
		}

		void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = 0; i < 100; i++)
			{
				(sender as BackgroundWorker).ReportProgress(i);
				Thread.Sleep(100);
			}
		}

		void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			FileSendReceiveProgress.Value = e.ProgressPercentage;
		}
        #endregion

        #region File Select
        // File Selection Button
        private void OpenFileSelect(object sender, RoutedEventArgs e)
        {
            OpenFileDialog FileSelectDialog = new OpenFileDialog();
            FileSelectDialog.Multiselect = true;
            FileSelectDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (FileSelectDialog.ShowDialog() == true)
            {
                foreach (string filename in FileSelectDialog.FileNames)
                    FilePathListbox.Items.Add(filename);
            }
        }   
        #endregion
    }
}
