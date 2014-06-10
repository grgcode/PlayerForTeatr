using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerForTeatr
{
    class PlayListItem
    {
        private string _fullPath;
        private string _file;
        private bool _played;

        public PlayListItem(string fileFullPath)
        {
            _fullPath = fileFullPath;
            _file = Path.GetFileName(_fullPath);
        }

        public override string ToString()
        {
            if (_played)
            {
                return _file.Substring(0,Math.Min(_file.Length, 20)) + "...";
            }
            else
            {
                return _file;
            }
        }

        public bool Played
        {
            get { return _played; }
            set { _played = value; }
        }

        public string FullFileName
        {
            get { return _fullPath; }
            set { _fullPath = value; }
        }


    }
}
