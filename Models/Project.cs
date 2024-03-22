using System.ComponentModel.DataAnnotations;

namespace BookLibraryProject.Models
{
    public class Project
    {
        [Key]

        public int BookID { get; set; }

        public string Title {  get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public int ISBN { get; set; }

        public string Classification { get; set; }

        public string Category { get; set; }

        public int PageCount { get; set; }

        public float Price { get; set; }

    }
}
