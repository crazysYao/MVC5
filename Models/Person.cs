using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5.Models
{
    public class Person
    {
        public int id { get; set; }
        [Required(ErrorMessage ="請輸入姓名")]
        public string Name { get; set; }
        [Required(ErrorMessage ="請輸入年紀")]
        [Range(18,99,ErrorMessage ="請輸入年紀18到99")]
        public int Age { get; set; }
    }
}