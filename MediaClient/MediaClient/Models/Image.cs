using System;
namespace MediaClient.Models
{
    public enum ImageFormat
    {
        BMP,
        JPG,
        PNG
    }

    public class Image : Media
    {
       


        public  ImageFormat Format{
            get;
            set;
        }


    }
}
