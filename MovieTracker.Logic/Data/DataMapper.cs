using Microsoft.Data.Sqlite;
using MovieTracker.Logic.Models;

namespace MovieTracker.Logic.Data
{
    /// <summary>
    /// Provides static methods for mapping data from a SqliteDataReader to domain objects such as Movie and Award.
    /// </summary>
    /// <remarks>This class is intended to facilitate the conversion of database query results into strongly
    /// typed objects. All methods are static and do not require instantiation of the DataMapper class.</remarks>
    public static class DataMapper
    {
        /// <summary>
        /// Maps a data reader row to a Movie object.
        /// </summary>
        public static Movie MapMovie(SqliteDataReader reader)
        {
            return new Movie
            {
                MovieId = reader.GetInt32(reader.GetOrdinal("MovieId")),
                Title = reader.GetString(reader.GetOrdinal("Title")),
                ReleaseYear = reader.IsDBNull(reader.GetOrdinal("ReleaseYear")) ? null : reader.GetInt32(reader.GetOrdinal("ReleaseYear")),
                Director = reader.IsDBNull(reader.GetOrdinal("Director")) ? null : reader.GetString(reader.GetOrdinal("Director")),
                TopActor = reader.IsDBNull(reader.GetOrdinal("TopActor")) ? null : reader.GetString(reader.GetOrdinal("TopActor")),
                Genre = reader.IsDBNull(reader.GetOrdinal("Genre")) ? null : reader.GetString(reader.GetOrdinal("Genre")),
                Series = reader.IsDBNull(reader.GetOrdinal("Series")) ? null : reader.GetString(reader.GetOrdinal("Series")),
                Runtime = reader.IsDBNull(reader.GetOrdinal("Runtime")) ? null : reader.GetInt32(reader.GetOrdinal("Runtime")),
                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                IsNationalFilmRegistry = reader.GetInt32(reader.GetOrdinal("IsNationalFilmRegistry")) == 1,
                IsDisney = reader.GetInt32(reader.GetOrdinal("IsDisney")) == 1,
                NationalFilmRegistryYear = reader.IsDBNull(reader.GetOrdinal("NationalFilmRegistryYear")) ? null : reader.GetInt32(reader.GetOrdinal("NationalFilmRegistryYear")),
                IsWatched = reader.GetInt32(reader.GetOrdinal("IsWatched")) == 1,
                FirstWatch = reader.GetInt32(reader.GetOrdinal("FirstWatch")) == 1,
                WatchedDate = reader.IsDBNull(reader.GetOrdinal("WatchedDate")) ? null : DateTime.Parse(reader.GetString(reader.GetOrdinal("WatchedDate"))),
                UserRating = reader.IsDBNull(reader.GetOrdinal("UserRating")) ? null : reader.GetInt32(reader.GetOrdinal("UserRating")),
                Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes")),
                DateAdded = reader.IsDBNull(reader.GetOrdinal("DateAdded")) 
                    ? DateTime.Now 
                    : DateTime.Parse(reader.GetString(reader.GetOrdinal("DateAdded")))
            };
        }

        /// <summary>
        /// Maps a data reader row to an Award object.
        /// </summary>
        public static Award MapAward(SqliteDataReader reader)
        {
            return new Award
            {
                AwardId = reader.GetInt32(reader.GetOrdinal("AwardId")),
                MovieId = reader.GetInt32(reader.GetOrdinal("MovieId")),
                AwardName = reader.GetString(reader.GetOrdinal("AwardName")),
                Category = reader.GetString(reader.GetOrdinal("Category")),
                Year = reader.GetInt32(reader.GetOrdinal("Year")),
                Won = reader.GetInt32(reader.GetOrdinal("Won")) == 1
            };
        }
    }
}