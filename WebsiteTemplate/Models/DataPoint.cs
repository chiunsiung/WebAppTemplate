﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebsiteTemplate.Models
{
    [DataContract]
    public class DataPoint
    {
        //public double TodaySales { get; set; }
        //public double LastWeekSales { get; set; }
        //public double LastMonthSales { get; set; }
        public DataPoint(string label, double y)
        {
            this.Label = label;
            this.Y = y;
        }

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "label")]
        public string Label = "";

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public Nullable<double> Y = null;

    }
}