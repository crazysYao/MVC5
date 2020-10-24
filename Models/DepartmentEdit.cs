
namespace MVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DepartmentEdit
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        public decimal Budget { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<int> InstructorID { get; set; }
    }
}
