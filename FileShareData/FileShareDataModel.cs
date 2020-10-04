// Using System
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace FileShareData
{
    public class FileShareDataModel : INotifyPropertyChanged
    {
        #region Private Lists and Vars
        // File Path List
        private static string _filePath;

        // Send IP Address
        private static string _sendIPAddress;

        // Send Port
        private static int _sendPort;

        // Send Buffer Size
        private static int _sendBufferSize;

        // Transfer Progress
        private static int _transferProgress;

        #endregion

        #region Public Variable Accessors and Setters
        public static string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        // Send IP Address
        public static string SendIPAddress
        {
            get => _sendIPAddress;
            set => _sendIPAddress = value;
        }

        // Send Port
        public static int SendPort
        {
            get => _sendPort;
            set => _sendPort = value;
        }

        // Send Buffer Size
        public static int SendBufferSize
        {
            get => _sendBufferSize;
            set => _sendBufferSize = value;
        }

        // Transfer Progress
        public static int TransferProgress
        {
            get => _transferProgress;
            set
            {
                _transferProgress = value;
                //NotifyPropertyChanged();
            }
        }

        #endregion

        #region Variable Change Notification Logic
        // Create event
        public event PropertyChangedEventHandler PropertyChanged;

        // Notify
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
