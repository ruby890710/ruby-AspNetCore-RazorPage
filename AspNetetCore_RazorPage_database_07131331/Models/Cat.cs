using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetetCore_RazorPage_database_07131331.Models
{
    public class Cat
    {
        public int ID { get; set; }

        [Display(Name = "主旨")]
        public string Title { get; set; }

        [Display(Name = "發布日期")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "留言內容")]
        public string Content { get; set; }

        [Display(Name = "評分")]
        public int Rate { get; set; }


        
    }
}
