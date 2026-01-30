namespace MovieTracker.Logic.Models
{
    /// <summary>
    /// Represents a movie, including details such as title, release year, director, runtime, and user-specific
    /// information.
    /// </summary>
    /// <remarks>The Movie class is used to store and manage information about individual films, including
    /// metadata, awards, and user tracking data such as watch status and personal notes. This class can be used in
    /// applications that catalog, display, or analyze movie collections.</remarks>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the unique identifier for the movie.
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// Gets or sets the title associated with the object.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the year in which the item was released.
        /// </summary>
        public int? ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets the name of the film's director.
        /// </summary>
        public string? Director { get; set; }

        /// <summary>
        /// Gets or sets the name of the actor with the most appearances.
        /// </summary>
        public string? TopActor { get; set; }

        /// <summary>
        /// Gets or sets the genre associated with the item.
        /// </summary>
        public string? Genre { get; set; }

        /// <summary>
        /// Gets or sets the name of the series associated with the item.
        /// </summary>
        public string? Series { get; set; }

        /// <summary>
        /// Gets or sets the total runtime of the item, in minutes.
        /// </summary>
        public int? Runtime { get; set; }

        /// <summary>
        /// Gets or sets the description associated with the object.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the film is included in the National Film Registry.
        /// </summary>
        public bool IsNationalFilmRegistry { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the content is associated with Disney.
        /// </summary>
        public bool IsDisney { get; set; }

        /// <summary>
        /// Gets or sets the year in which the film was added to the National Film Registry.
        /// </summary>
        public int? NationalFilmRegistryYear { get; set; }

        /// <summary>
        /// Gets or sets the collection of awards associated with this entity.
        /// </summary>
        public List<Award> Awards { get; set; } = [];

        /// <summary>
        /// Gets or sets a value indicating whether the item has been marked as watched.
        /// </summary>
        public bool IsWatched { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the first time the item is being watched.
        /// </summary>
        public bool FirstWatch { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the item was watched.
        /// </summary>
        public DateTime? WatchedDate { get; set; }

        /// <summary>
        /// Gets or sets the user-provided rating for the item.
        /// </summary>
        public int? UserRating { get; set; }

        /// <summary>
        /// Gets or sets optional notes or comments associated with the object.
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the item was added.
        /// </summary>
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}