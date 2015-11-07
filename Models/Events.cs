using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show_Seek.Models
{
    class Events
    {

    }

    public class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        public string PictureURL { get; set; }
        public string Notes { get; set; }
        public bool AgeRestricted { get; set; }
        public bool IsSaved { get; set; }

        public DateTime EventDate
        {
            get { return DateTime.Now; }
        }
        public ApiServiceProvider Servicetype { get; set; }
        public DateTime LastPull { get; set; }
        public List<Artist> Artists { get; set; }
        public List<DateTime> Dates { get; set; } 
    }

    public enum ApiServiceProvider
    {
        SongKick,
        LastFm,
        Eventful,
        EventBrite,
        Upcoming,
        TourVolume,
        BandsInTown,
        FiveGig,
        SonicLiving

    }

    public class Artist
    {
        private string[] _websites;
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string[] Websites
        {
            get { return _websites; }
            set { _websites = value; }
        }
    }
}
