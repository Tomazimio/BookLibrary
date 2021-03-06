﻿namespace BookLibrary.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Author
    {
        private ICollection<Book> books;

        public Author()
        {
            this.books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        public string LastName { get; set; }

        public virtual ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }

    }
}
