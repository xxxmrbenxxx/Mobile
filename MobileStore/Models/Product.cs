using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MobileStore.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }
        public virtual ICollection<Mobile> Mobiles { get; set; }
    }
}