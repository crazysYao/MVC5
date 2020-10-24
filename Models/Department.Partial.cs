using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5.Models
{
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department
    {
        public class DepartmentMetaData
        {
            public int DepartmentID { get; set; }
            [Required(ErrorMessage ="haha")]
            public string Name { get; set; }
            public decimal Budget { get; set; }
            public Nullable<System.DateTime> StartDate { get; set; }
            public Nullable<int> InstructorID { get; set; }
            public byte[] RowVersion { get; set; }
            public virtual ICollection<Course> Course { get; set; }
            public virtual Person Person { get; set; }
        }
    }
}