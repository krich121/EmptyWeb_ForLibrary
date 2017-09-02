using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace EmptyWeb_ForLibrary.Util
{
    public static class ImageExtension
    {
        public static string ToBase64(this Image originalValue)
        {
            string base64String = string.Empty;

            if (originalValue != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ImageFormat format = originalValue.RawFormat;

                    // Convert Image to byte[]
                    originalValue.Save(ms, format);
                    byte[] imageBytes = ms.ToArray();

                    // Convert byte[] to Base64 String
                    base64String = Convert.ToBase64String(imageBytes);
                }
            }

            return base64String;
        }

        public static byte[] ToByteArray(this Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}