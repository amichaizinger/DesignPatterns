using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Video
    {
        private string _title;
        private string _director;
        private int _duration; // in seconds

        public Video(string title, string director, int duration)
        {
            _title = title;
            _director = director;
            _duration = duration;
        }
    }
}
