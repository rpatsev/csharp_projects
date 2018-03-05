using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class VideoFile : File
    {
        string resolution;
        int duration;

        public VideoFile(string extension, int size, string resolution, int duration)
        {
            this.extension = extension;
            this.size = size;
            this.resolution = resolution;
            this.duration = duration;
        }
    }
}
