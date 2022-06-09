using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication2.Models
{
    public partial class TblStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int CourseId { get; set; }
    }
}
