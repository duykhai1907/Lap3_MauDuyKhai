using Duy_Khai___Lap_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Duy_Khai___Lap_3.Views.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}