using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Linq;

namespace Laborator2.Models
{
    public class Book
    {
        [ForeignKey("Author")]
        public int ID{ get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
    
        public decimal Price { get; set; }

        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

       public virtual Author Author { get; set; }
        

    }
}
    

