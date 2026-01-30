namespace MovieTracker.Logic.Models
{
    /// <summary>
    /// Represents a summary of movies for a specific year.
    /// </summary>
    public class Summary
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the year value.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the collection of movies associated with this instance.
        /// </summary>
        public required List<Movie> Movies { get; set; }
    }
}