// Using System
using System;
using System.Collections.Generic;



namespace FileShareData
{
    public class FileShareDataModel
    {
        #region Private Lists and Vars
        // File Path List
        //private static List<String> _filePaths;
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
            set => _transferProgress = value;
        }

        #endregion

        #region Public List Accessors
        // File Path List Accessor
        //public static List<String> FilePaths
        //{
        //    get
        //    {
        //        if (_filePaths == null)
        //        {
        //            _filePaths = new List<String>();
        //        }

        //        return _filePaths;
        //    }
        //}

        #endregion

        #region Public List Setter
        // File Path List Setter
        //public static void AddFilePath(string filepath)
        //{
        //    if (_filePaths == null)
        //    {
        //        _filePaths = new List<String>();
        //    }

        //    _filePaths.Add(filepath);
        //}

        #endregion
    }
}
