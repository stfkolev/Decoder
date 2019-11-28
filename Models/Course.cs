using System.Collections.Generic;

namespace Decoder.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseTitle { get; set; }
        public int HasTranscript { get; set; }
        public List<Module> Modules { get; set; }

        public Course()
        {
            Modules = new List<Module>();
        }
    }
}