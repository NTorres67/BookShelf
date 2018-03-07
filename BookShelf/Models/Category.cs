using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShelf.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public virtual ICollection<Book> Books { get; set; }    //Nav Prop Books because it contains multiple items

    }
}