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
using Windows.Web.Syndication;



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

            Mediator.Subscribe("StartProgressBar", StartProgressBar);
        }

        // Focus on background when clicked
        private void ApplicationWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ApplicationBackground.Focus();
        }

        #region Sidebar Buttons
        // Send Panel
        private void OnGoSendPanel(object sender, RoutedEventArgs e)
        {
            Mediator.Notify("GoToSendPanel", "");
        }
        private void OnGoReceivePanel(object sender, RoutedEventArgs e)
        {
            Mediator.Notify("GoToReceivePanel", "");
        }
        private void OnGoSettingsPanel(object sender, RoutedEventArgs e)
        {
            Mediator.Notify("GoToSettingsPanel", "");
        }
        #endregion

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
        private async void StartProgressBar(object sender)
        {
            await Task.Run(() =>
            {
                while (FileShareDataModel.TransferComplete == false)
                {
                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        // Run on UI Thread
                        FileSendReceiveProgress.Value = FileShareDataModel.TransferProgress;
                    }));
                }
            });
        }
        #endregion
    }
}
