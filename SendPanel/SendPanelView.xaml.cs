// Using Class Libraries
using FileShareData;

// Using System
using System;
using System.Windows;
using System.Windows.Controls;

// Using Win32
using Microsoft.Win32;



namespace SendPanel
{
    /// <summary>
    /// Interaction logic for SendPanelView.xaml
    /// </summary>
    public partial class SendPanelView : UserControl
    {
        // Instantiate Data from Model
        FileShareDataModel applicationModel = new FileShareDataModel();

        public SendPanelView()
        {
            InitializeComponent();
        }

        #region Form Background Text Logic
        // On IP Address Bar enter, set content to empty
        private void IPBlockEnter(object sender, EventArgs e)
        {
            if (IPBlock.Text == "IP Address")
            {
                IPBlock.Text = "";
            }
        }

        // On IP Address Bar leave, set content to "IP Address"
        private void IPBlockLeave(object sender, EventArgs e)
        {
            if (IPBlock.Text.Length == 0)
            {
                IPBlock.Text = "IP Address";
            }
        }

        // On Port Bar enter, set content to empty
        private void PortBlockEnter(object sender, EventArgs e)
        {
            if (PortBlock.Text == "Port")
            {
                PortBlock.Text = "";
            }
        }

        // On Port Bar leave, set content to "Port"
        private void PortBlockLeave(object sender, EventArgs e)
        {
            if (PortBlock.Text.Length == 0)
            {
                PortBlock.Text = "Port";
            }
        }

        // On IP Address Bar enter, set content to empty
        private void BufferBlockEnter(object sender, EventArgs e)
        {
            if (BufferBlock.Text == "Buffer Size")
            {
                BufferBlock.Text = "";
            }
        }

        // On IP Address Bar leave, set content to "IP Address"
        private void BufferBlockLeave(object sender, EventArgs e)
        {
            if (BufferBlock.Text.Length == 0)
            {
                BufferBlock.Text = "Buffer Size";
            }
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
                foreach (string filepath in FileSelectDialog.FileNames)
                {
                    applicationModel.AddFilePath(filepath);
                }
            }
        }

        // File Drag and Drop
        private void FileUploadDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string filepath in files)
                {
                    applicationModel.AddFilePath(filepath);
                }
            }
        }
        #endregion

        // TESTING:
        private void UpdateListBox(object sender, RoutedEventArgs e)
        {
            var FilePaths = applicationModel.FilePaths;
            FilePathListbox.Items.Clear();
            foreach (string filepath in FilePaths)
            {
                FilePathListbox.Items.Add(filepath);
            }
        }
    }
}
