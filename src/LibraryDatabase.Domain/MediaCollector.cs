using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Domain
{
    public class MediaCollector
    {
        public List<AbstractMedia> Collector;

        public MediaCollector()
        {
            Collector = new List<AbstractMedia>();
        }

        private void AddMedia(AbstractMedia media)
        {
            Collector.Add(media);
        }

        private void RemoveMedia(AbstractMedia media)
        {
            Collector.Remove(media);
        }
    }
}
