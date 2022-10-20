namespace Laborator2.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Book Book { get; set; } 

        
    }
}
