using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Song
    {
        //class to check list of songs
        public string title;
        public string artist;
        public int duration;
        public static int SongCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            SongCount++;
        }

        public int songCount()
        {
            return SongCount;
        }
    }
}
