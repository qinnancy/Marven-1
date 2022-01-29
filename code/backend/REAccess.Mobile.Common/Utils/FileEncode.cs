#region Using
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Utils
{
    public static class FileEncode
    {
        public static byte[] GetImageBytes(string imgPath)
        {
            //从图片中读取byte
            var fileBytes = File.ReadAllBytes(imgPath);
            ////从图片中读取流
            //var imgStream = new MemoryStream(fileBytes);

            return fileBytes;
        }
    }
}
