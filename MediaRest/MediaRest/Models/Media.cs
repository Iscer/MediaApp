using System;

namespace MediaRest.Models
{
    public  class Media
    {

        public int  Id{
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Path
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
  
        }

        public string Size{
            get {
                return $"{Width} x {Height}";
            }
        }

          

    }
}
