namespace BookLibrary.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Genre
    {

        public int GenreId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string GenreName { get; set; }
    }
}
