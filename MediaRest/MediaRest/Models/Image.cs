using System;
namespace MediaRest.Models
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
