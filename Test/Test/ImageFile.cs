using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ImageFile : File
    {
        string resolution;

        ImageFile(string extension, int size, string resolution)
        {
            this.extension = extension;
            this.size = size;
            this.resolution = resolution;
        }
    }
}
