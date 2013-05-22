using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    public class MediaItem
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Album { get; set; }
        public int Length { get; set; }
        public string Location { get; set; }
    }
}
