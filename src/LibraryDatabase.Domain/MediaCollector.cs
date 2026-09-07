using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
    public class MediaCollector
    {
        public List<Media> Collector;

        public MediaCollector()
        {
            Collector = new List<Media>();
        }

        private void AddMedia(Media media)
        {
            Collector.Add(media);
        }

        private void RemoveMedia(Media media)
        {
            Collector.Remove(media);
        }
    }
}
