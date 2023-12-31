namespace Giraffe
{
    class Song
    {
        public string artist;
        public string title;
        public int duration;
        public static int songCount = 0;

        public Song(string sArtist, string sTitle, int sDuration)
        {
            artist = sArtist;
            title = sTitle;
            duration = sDuration;
            songCount += 1;
        }
        public int getSongCount()
        {
            return songCount;
        }
    }
}