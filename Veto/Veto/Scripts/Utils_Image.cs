using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veto
{
    public static partial class Utils
    {
        /// <summary>
        /// Convert a bitmap into a byte[]
        /// </summary>
        /// <param name="img">the bitmap</param>
        /// <returns>the byte[]</returns>
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        /// <summary>
        /// Convert a byte[] into a bitmap
        /// </summary>
        /// <param name="img">the byte[]</param>
        /// <returns>the bitmap</returns>
        public static Image ByteToImage(byte[] img)
        {
            ImageConverter converter = new ImageConverter();
            return (Image)converter.ConvertTo(img, typeof(Image));
        }
    }
}
