using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TextFile : File
    {
        string content;

        public TextFile()
        {

        }

        public TextFile(string extension, int size, string content)
        {
            this.extension = extension;
            this.size = size;
            this.content = content;
        }


    }
}
