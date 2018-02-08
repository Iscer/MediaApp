using System;
namespace MediaMvc.Models
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
