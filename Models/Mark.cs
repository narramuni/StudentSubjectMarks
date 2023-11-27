using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSubjectMarks.Models
{
    public class Marks
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Mark { get; set; }
    }
}