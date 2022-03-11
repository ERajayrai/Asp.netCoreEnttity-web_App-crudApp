using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationAspCoreEntity.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public int RollNumber { get; set; }
    }
}
