#region Using
//using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Utils
{
    public static class ImageHelper
    {
        public static void MagickImage()
        {
            //install Magick.NET-Q16-AnyCPU
            //DirectoryInfo directory = new DirectoryInfo($"{Directory.GetCurrentDirectory()}\\RealTimeInfoImgs");
            //FileInfo[] files = directory.GetFiles();
            //foreach(var file in files)
            //{
            //    var fileSize = file.Length / 1024;
            //    if(fileSize > 500)
            //    {
            //        var fileName = file.Name.Replace(".png", "");
            //        file.MoveTo($"{directory}\\{file.Name.Replace(".png", "")}-old.png");
            //        //打开文件
            //        FileStream fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
            //        //读取文件的byte
            //        byte[] bytes = new byte[fileStream.Length];
            //        fileStream.Read(bytes, 0, bytes.Length);
            //        fileStream.Close();
            //        //把byte[]转换成Stream
            //        Stream stream = new MemoryStream(bytes);

            //        MagickImage image = new MagickImage(stream);
            //        //image.Resize(new MagickGeometry(600, 300));
            //        image.Format = MagickFormat.Jpg;
            //        image.Write($"{Directory.GetCurrentDirectory()}\\RealTimeInfoImgs\\{fileName}.jpg");
            //    }
            //}
        }
    }
}
