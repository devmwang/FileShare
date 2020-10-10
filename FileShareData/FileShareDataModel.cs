// Using System
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace FileShareData
{
    public class FileShareDataModel
    {
        #region Private Lists and Vars
        // File Path
        private static string _filePath;

        // Send IP Address
        private static string _sendIPAddress;

        // Send Port
        private static int _sendPort;

        // Transfer Progress
        private static int _transferProgress;

        // Transfer Complete
        private static bool _transferComplete;

        // Receive File Location
        private static string _fileSavePath;

        // Receive Port
        private static int _receivePort;

        #endregion

        #region Public Variable Accessors and Setters
        // File Path
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

        // Transfer Progress
        public static int TransferProgress
        {
            get => _transferProgress;
            set
            {
                _transferProgress = value;
            }
        }

        // Transfer Complete
        public static bool TransferComplete
        {
            get => _transferComplete;
            set => _transferComplete = value;
        }

        // Receive File Location
        public static string FileSavePath
        {
            get => _fileSavePath;
            set => _fileSavePath = value;
        }

        // Receive Port
        public static int ReceivePort
        {
            get => _receivePort;
            set => _receivePort = value;
        }

        #endregion
    }
}
