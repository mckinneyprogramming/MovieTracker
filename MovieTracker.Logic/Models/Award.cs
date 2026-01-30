namespace MovieTracker.Logic.Models
{
    /// <summary>
    /// Represents an award received or nominated for a specific category and year.
    /// </summary>
    public class Award
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public int AwardId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the movie.
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// Gets or sets the name of the award.
        /// </summary>
        public string AwardName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the category associated with the item.
        /// </summary>
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the year component.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the movie won.
        /// </summary>
        public bool Won { get; set; }
    }
}