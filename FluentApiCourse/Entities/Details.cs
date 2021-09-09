﻿using System;

namespace FluentApiCourse.Entities
{
    public class Details
    {
        public int DetailsID { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public string Days { get; set; }

        public Details()
        {
        }

        public Details(int detailsID, DateTime time, string location, string days)
        {
            DetailsID = detailsID;
            Time = time;
            Location = location;
            Days = days;
        }
    }
}
