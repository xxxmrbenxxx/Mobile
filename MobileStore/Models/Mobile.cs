using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MobileStore.Models
{
    public class Mobile
    {
        [ScaffoldColumn(false)]
        [Key] 
        public int MoblieID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string MoblieName { get; set; }
        [Required, StringLength(1000), Display(Name = "Mobile Description"),
        DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public float? Price { get; set; }
        public int? ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}