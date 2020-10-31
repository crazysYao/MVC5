namespace MVC5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CourseMetaData))]
    public partial class Course
    {
    }
    
    public partial class CourseMetaData
    {
        [Required]
        public int CourseID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string Title { get; set; }
        [Required]
        [MustBeEven]
        public int Credits { get; set; }
        [Required]
        public int DepartmentID { get; set; }
        
        [StringLength(200, ErrorMessage="欄位長度不得大於 200 個字元")]
        public string Memo { get; set; }
    }

    public class CourseBatchEditVM
    {
        [Required]
        public int CourseID { get; set; }

        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1, 5)]
        public int Credits { get; set; }
    }
}
