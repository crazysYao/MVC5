namespace MVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Name != "Will" && this.Budget > 100)
            {
                yield return new ValidationResult("您的預算不足", new string[] { "Budget" });
            }
        }
    }

    public partial class DepartmentMetaData
    {
        [Required]
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Name 是必要項")]
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string Name { get; set; }

        [Required]
        [MustBeEven]
        public decimal Budget { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> InstructorID { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
    
        public virtual ICollection<Course> Course { get; set; }
        public virtual Person Person { get; set; }
    }
}
