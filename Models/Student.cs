using System;

namespace QL_SinhVIen.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentCode { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int ClassId { get; set; }
        public string Notes { get; set; }
    }
}
