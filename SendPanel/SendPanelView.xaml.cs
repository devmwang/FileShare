// Using Class Libraries
using FileShareData;

// Using System
using System;
using System.Windows;
using System.Windows.Controls;

// Using Win32
using Microsoft.Win32;
using System.Linq.Expressions;

namespace SendPanel
{
    /// <summary>
    /// Interaction logic for SendPanelView.xaml
    /// </summary>
    public partial class SendPanelView : UserControl
    {
        // Instantiate Data from Model
        FileShareDataModel FSDataModel = new FileShareDataModel();

        public SendPanelView()
        {
            InitializeComponent();
        }

        #region Send Form Logic
        private void SendFile(object sender, RoutedEventArgs e)
        {
            FSDataModel.SendIPAddress = IPBlock.Text;

            try
            {
                FSDataModel.SendPort = Int32.Parse(PortBlock.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("SendPort Str -> Int Parse Failed");
            }

            try
            {
                FSDataModel.SendBufferSize = Int32.Parse(BufferBlock.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("SendBufferSize Str -> Int Parse Failed");
            }
        }
        #endregion

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
        private void FileUploadSelect(object sender, RoutedEventArgs e)
        {
            OpenFileDialog FileSelectDialog = new OpenFileDialog();
            FileSelectDialog.Multiselect = true;
            FileSelectDialog.Filter = "All files (*.*)|*.*";
            FileSelectDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (FileSelectDialog.ShowDialog() == true)
            {
                foreach (string filepath in FileSelectDialog.FileNames)
                {
                    FSDataModel.AddFilePath(filepath);
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
                    FSDataModel.AddFilePath(filepath);
                }
            }
        }
        #endregion

        // TESTING:
        private void UpdateListBox(object sender, RoutedEventArgs e)
        {
            var FilePaths = FSDataModel.FilePaths;
            var SendIPData = FSDataModel.SendIPAddress;
            var SendPortData = FSDataModel.SendPort;
            var SendBufferSizeData = FSDataModel.SendBufferSize;

            FilePathListbox.Items.Clear();
            foreach (string filepath in FilePaths)
            {
                FilePathListbox.Items.Add(filepath);
            }

            FilePathListbox.Items.Add(SendIPData);
            FilePathListbox.Items.Add(SendPortData);
            FilePathListbox.Items.Add(SendBufferSizeData);
        }
    }
}
