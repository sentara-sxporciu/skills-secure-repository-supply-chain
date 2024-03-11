using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace Attendees
{

    public class Attendee
    {
        public void WriteToDirectory(ZipArchiveEntry entry, string destDirectory)
        {
            /*
            string destFileName = Path.Combine(destDirectory, entry.FullName);
            string fullDestDirPath = Path.GetFullPath(destDirectory + Path.DirectorySeparatorChar);
            if (!destFileName.StartsWith(fullDestDirPath))
            {
                throw new System.InvalidOperationException("Entry is outside the target dir: " + destFileName);
            }
            entry.ExtractToFile(destFileName);
            */
            Debug.Write("test");
        }
        
        public bool AddAttendee(string added)
        {
            if (added == "exists") {
                  return true;
            }
            return false;
        }      
    }
}