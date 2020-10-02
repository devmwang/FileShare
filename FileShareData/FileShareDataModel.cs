// Using System
using System;
using System.Collections.Generic;



namespace FileShareData
{
    public class FileShareDataModel
    {
        #region Private Lists and Vars
        // File Path List
        private List<String> _filePaths;

        // Send IP Address
        private string _sendIPAddress = "hehe";

        // Send Port
        private int _sendPort;

        // Send Buffer Size
        private int _sendBufferSize;

        #endregion

        #region Public Variable Accessors and Setters
        // Send IP Address
        public string SendIPAddress
        {
            get
            {
                return _sendIPAddress;
            }
            set
            {
                _sendIPAddress = value;
            }
        }

        // Send Port
        public int SendPort
        {
            get
            {
                return _sendPort;
            }
            set
            {
                _sendPort = value;
            }
        }

        // Send Buffer Size
        public int SendBufferSize
        {
            get
            {
                return _sendBufferSize;
            }
            set
            {
                _sendBufferSize = value;
            }
        }

        #endregion

        #region Public List Accessors
        // File Path List Accessor
        public List<String> FilePaths
        {
            get
            {
                if (_filePaths == null)
                {
                    _filePaths = new List<String>();
                }

                return _filePaths;
            }
        }

        #endregion

        #region Public List Setter
        // File Path List Setter
        public void AddFilePath(string filepath)
        {
            if (_filePaths == null)
            {
                _filePaths = new List<String>();
            }

            _filePaths.Add(filepath);
        }

        #endregion
    }
}
