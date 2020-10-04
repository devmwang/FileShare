// Using Class Libraries
using FileShareData;
using FileSend;

// Using System
using System;
using System.Windows;
using System.Windows.Controls;

// Using Win32
using Microsoft.Win32;
using System.Linq.Expressions;
using System.ComponentModel;

namespace SendPanel
{
    /// <summary>
    /// Interaction logic for SendPanelView.xaml
    /// </summary>
    public partial class SendPanelView : UserControl
    {
        // Instantiate File Send Logic
        FileSendLogic FileSend = new FileSendLogic();

        public SendPanelView()
        {
            InitializeComponent();
        }

        #region Send Form Logic
        // Save data in form and send attached file.
        private void SendFileBttn(object sender, RoutedEventArgs e)
        {
            // Save all the form data
            FileShareDataModel.SendIPAddress = IPBlock.Text;

            try
            {
                FileShareDataModel.SendPort = Int32.Parse(PortBlock.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("SendPort Str -> Int Parse Failed");
            }

            try
            {
                FileShareDataModel.SendBufferSize = Int32.Parse(BufferBlock.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("SendBufferSize Str -> Int Parse Failed");
            }

            // Send File
            // Async Run File Send
            SendFileAsync();
        }
            
        // Async Function
        private async void SendFileAsync()
        {
            await FileSend.SendFile();
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
            // Dialog Window
            OpenFileDialog FileSelectDialog = new OpenFileDialog();
            FileSelectDialog.Multiselect = false;
            FileSelectDialog.Filter = "All files (*.*)|*.*";
            FileSelectDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (FileSelectDialog.ShowDialog() == true)
            {
                //foreach (string filepath in FileSelectDialog.FileNames)
                //{
                //    FSDataModel.AddFilePath(filepath);
                //}
                FileShareDataModel.FilePath = FileSelectDialog.FileName;
            }
        }

        // File Drag and Drop
        //private void FileUploadDrop(object sender, DragEventArgs e)
        //{
        //    // Drag and Drop Logic
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        // Note that you can have more than one file.
        //        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

        //        foreach (string filepath in files)
        //        {
        //            FSDataModel.AddFilePath(filepath);
        //        }
        //    }
        //}
        #endregion

        // TESTING:
        private void UpdateListBox(object sender, RoutedEventArgs e)
        {
            // Testing Code
            var FilePath = FileShareDataModel.FilePath;
            var SendIPData = FileShareDataModel.SendIPAddress;
            var SendPortData = FileShareDataModel.SendPort;
            var SendBufferSizeData = FileShareDataModel.SendBufferSize;

            FilePathListbox.Items.Clear();
            //foreach (string filepath in FilePaths)
            //{
            //    FilePathListbox.Items.Add(filepath);
            //}
            FilePathListbox.Items.Add(FilePath);
            FilePathListbox.Items.Add(SendIPData);
            FilePathListbox.Items.Add(SendPortData);
            FilePathListbox.Items.Add(SendBufferSizeData);
        }
    }
}
