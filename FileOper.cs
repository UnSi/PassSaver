using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PassSaver
{
    class FileOper
    {
        public bool CheckIfFileIsBeingUsed(string fileName)
        {
            try
            {
                var myFile = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                myFile.Close();
            }

            catch
            {
                return true;
            }
            return false;
        }
        public void CheckFolders()
        {
            if (!Directory.Exists("Error"))
                Directory.CreateDirectory("Error");
            if (!Directory.Exists("Backup"))
                Directory.CreateDirectory("Backup");
            if (!Directory.Exists("Wtf"))
                Directory.CreateDirectory("Wtf");
        }
    }
}
