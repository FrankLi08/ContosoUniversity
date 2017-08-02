using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{


    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText ="No grade")]
        public Grade? Grade { get; set; }
        //meaning
        public virtual Course Course { get; set; }
        //why should I use virtual course
        public virtual Student Student { get; set; }

    }
}