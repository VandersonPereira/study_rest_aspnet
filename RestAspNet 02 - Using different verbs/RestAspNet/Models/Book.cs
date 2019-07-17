using RestAspNet.Models.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAspNet.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }
}
