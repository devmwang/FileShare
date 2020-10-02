// Using System
using System;
using System.Collections.Generic;
using System.ComponentModel;



namespace FileShareData
{
    public class FileShareDataModel
    {
        #region Private Lists and Vars
        // Private File Path List
        private List<String> _filePaths;

        #endregion

        #region Public List and Var Accessors and Setters
        // Public File Path List Accessor
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

        #region Public File Path List Setter
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
