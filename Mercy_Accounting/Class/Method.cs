using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mercy_Accounting.Class
{
    class Method
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] by;

        // convert image to byte
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }

        // convert byte to image
        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }

    }
}
