using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3Remap
{
    class Song
    {
        public String FileName;
        public String OriginalFileName;
        public String SongName;
        public String ArtistName;
        public String FileNameArtist;
        public String FileNameSong;

        public String createFileName()
        {
            String createdName = "";
            createdName += ArtistName;
            createdName += " - ";
            createdName += SongName;
            return createdName;
        }
    }
}
