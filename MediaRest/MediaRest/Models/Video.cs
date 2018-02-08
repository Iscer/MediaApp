﻿using System;

namespace MediaRest.Models
{
    public enum VideoFormat
    {
        MP4,
        AVI,
        FLW
    }

    public class Video : Media
    {
       
       

        public VideoFormat Format{
            get;
            set;
        }

        public TimeSpan LengthTime{
            get;
            set;
        }
    }
}
