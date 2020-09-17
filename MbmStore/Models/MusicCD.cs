using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public TimeSpan PlayingTime {

            get
            {
                var totalTime = new TimeSpan(0, 0, 0);
                foreach (Track track in Tracks)
                {
                    totalTime = totalTime + track.Length;
                }
                return totalTime;
            } 
            private set { } 
        }

        //private List<string> tracks = new List<string>();
        public List<Track> Tracks { get; private set; } = new List<Track>();


        public MusicCD() { }
        public MusicCD(string artist, string title, decimal price, short released) : base(title, price) {
            Artist = artist;
            Released = released;
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }

        public TimeSpan GetPlayingTime()
        {
            var totalTime = new TimeSpan(0, 0, 0);
foreach(Track track in Tracks)
            {
                totalTime= totalTime + track.Length;
            }
            return totalTime;

        }
    }
}
