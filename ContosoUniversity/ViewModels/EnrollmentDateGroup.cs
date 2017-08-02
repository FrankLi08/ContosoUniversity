﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        //datatype meaning
        public DateTime? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }

    }
}