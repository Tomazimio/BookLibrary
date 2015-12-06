namespace BookLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        private ICollection<Author> authors;

        public Book()
        {
            this.authors = new HashSet<Author>();
        }

        public int BookId { get; set; }
 
        [Required]
        [MinLength(1)]
        [MaxLength(300)]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Author> Autors
        {
            get { return this.authors; }
            set { this.authors = value; }
        }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
