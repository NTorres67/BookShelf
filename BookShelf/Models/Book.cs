using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookShelf.Models
{
    public class Book
    {
        [Key]                                          // primary Key 
        public int BookID { get; set; }                // unique identifier
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]                        //primary key in another model - set up relationship
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }  // Navigation property Category squiggle line will go away after built

    }
}