// Using Class Libraries
using AssistanceClasses;

// Using System
using System;
using System.Collections.Generic;
using System.ComponentModel;



namespace FileShare
{
    public class ApplicationModel : ObservableObject
    {
        // Private Lists and Vars
        // Private File Path List
        private List<String> _filePaths;

        // Public List and Var Accessors and Setters
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

        // Public File Path List Setter
        public void AddFilePath(string filepath)
        {
            if (_filePaths == null)
            {
                _filePaths = new List<String>();
            }

            _filePaths.Add(filepath);
        }
    }
}
