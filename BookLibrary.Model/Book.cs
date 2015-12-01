namespace BookLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        private ICollection<Author> autors;
        private ICollection<Genre> genres;


        public Book() {
            this.autors = new HashSet<Author>();
            this.genres = new HashSet<Genre>();
        }

        public int BookId { get; set; }
 
        [Required]
        [MinLength(1)]
        [MaxLength(300)]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int AuthorId { get; set; }

        public int GenreId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Author> Autors
        {
            get { return this.autors; }
            set { this.autors = value; }
        }

        public virtual ICollection<Genre> Genres
        {
            get { return this.genres; }
            set { this.genres = value; }
        }

    }
}
