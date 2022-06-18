using Duy_Khai___Lap_3.Models;
using System.Linq;

namespace Duy_Khai___Lap_3.Controllers
{
    internal class CoursesViewModel
    {
        public IQueryable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}