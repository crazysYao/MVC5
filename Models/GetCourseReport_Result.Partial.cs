namespace MVC5.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(GetCourseReport_ResultMetaData))]
    public partial class GetCourseReport_Result
    {
    }
    
    public partial class GetCourseReport_ResultMetaData
    {
        [Required]
        public int CourseID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string CourseName { get; set; }
        public Nullable<int> TeacherCount { get; set; }
        public Nullable<int> StudentCount { get; set; }
        public Nullable<double> AvgGrade { get; set; }
    }
}
