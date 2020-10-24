namespace MVC5.Models
{
    using System;
    using System.Collections.Generic;

    public partial class CourseEdit
    {
        public CourseEdit()
        {
        }
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public string Memo { get; set; }
    }
}
