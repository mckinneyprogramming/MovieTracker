using Microsoft.Data.Sqlite;
using MovieTracker.Logic.Models;

namespace MovieTracker.Logic.Data
{
    /// <summary>
    /// Provides helper methods for adding strongly-typed parameters to SQL commands for movie and award data.
    /// </summary>
    /// <remarks>This static class is intended to simplify the process of mapping domain objects to SQL
    /// command parameters when interacting with a SQLite database. All methods are static and thread-safe.</remarks>
    public static class DataParameters
    {
        /// <summary>
        /// Adds movie parameters to a SQL command.
        /// </summary>
        public static void AddMovieParameters(SqliteCommand command, Movie movie)
        {
            command.Parameters.AddWithValue("@Title", movie.Title);
            command.Parameters.AddWithValue("@ReleaseYear", (object?)movie.ReleaseYear ?? DBNull.Value);
            command.Parameters.AddWithValue("@Director", (object?)movie.Director ?? DBNull.Value);
            command.Parameters.AddWithValue("@TopActor", (object?)movie.TopActor ?? DBNull.Value);
            command.Parameters.AddWithValue("@Genre", (object?)movie.Genre ?? DBNull.Value);
            command.Parameters.AddWithValue("@Series", (object?)movie.Series ?? DBNull.Value);
            command.Parameters.AddWithValue("@Runtime", (object?)movie.Runtime ?? DBNull.Value);
            command.Parameters.AddWithValue("@Description", (object?)movie.Description ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsNationalFilmRegistry", movie.IsNationalFilmRegistry ? 1 : 0);
            command.Parameters.AddWithValue("@IsDisney", movie.IsDisney ? 1 : 0);
            command.Parameters.AddWithValue("@NationalFilmRegistryYear", (object?)movie.NationalFilmRegistryYear ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsWatched", movie.IsWatched ? 1 : 0);
            command.Parameters.AddWithValue("@FirstWatch", movie.FirstWatch ? 1 : 0);
            command.Parameters.AddWithValue("@WatchedDate", movie.WatchedDate.HasValue ? movie.WatchedDate.Value.ToString("yyyy-MM-dd HH:mm:ss") : DBNull.Value);
            command.Parameters.AddWithValue("@UserRating", (object?)movie.UserRating ?? DBNull.Value);
            command.Parameters.AddWithValue("@Notes", (object?)movie.Notes ?? DBNull.Value);
            command.Parameters.AddWithValue("@DateAdded", movie.DateAdded.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        /// <summary>
        /// Adds award parameters to a SQL command.
        /// </summary>
        public static void AddAwardParameters(SqliteCommand command, Award award)
        {
            command.Parameters.AddWithValue("@MovieId", award.MovieId);
            command.Parameters.AddWithValue("@AwardName", award.AwardName);
            command.Parameters.AddWithValue("@Category", award.Category);
            command.Parameters.AddWithValue("@Year", award.Year);
            command.Parameters.AddWithValue("@Won", award.Won ? 1 : 0);
        }
    }
}