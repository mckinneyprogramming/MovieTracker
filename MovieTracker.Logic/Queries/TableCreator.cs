namespace MovieTracker.Logic.Queries
{
    /// <summary>
    /// Provides static methods for generating SQL statements to create tables and indexes for a movie database schema.
    /// </summary>
    /// <remarks>Use the methods in this class to obtain SQL commands for initializing the required tables and
    /// indexes in a SQLite database. The generated statements include table definitions for movies, awards, yearly
    /// summaries, and summary-movie relationships, as well as recommended indexes to optimize query performance. This
    /// class is intended for database setup and migration scenarios where the schema must be created or ensured to
    /// exist.</remarks>
    public class TableCreator
    {
        /// <summary>
        /// Generates the SQL statement for creating the Movies table.
        /// </summary>
        /// <returns>The SQL statement for creating the Movies table.</returns>
        public static string MovieTable()
        {
            return @"CREATE TABLE IF NOT EXISTS Movies (
                MovieId INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL,
                ReleaseYear INTEGER,
                Director TEXT,
                TopActor TEXT,
                Genre TEXT,
                Series TEXT,
                Runtime INTEGER,
                Description TEXT,
                IsNationalFilmRegistry INTEGER NOT NULL DEFAULT 0,
                IsDisney INTEGER NOT NULL DEFAULT 0,
                NationalFilmRegistryYear INTEGER,
                IsWatched INTEGER NOT NULL DEFAULT 0,
                FirstWatch INTEGER NOT NULL DEFAULT 0,
                WatchedDate TEXT,
                UserRating INTEGER,
                Notes TEXT,
                DateAdded TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP
            );";
        }

        /// <summary>
        /// Generates the SQL statement for creating the Awards table.
        /// </summary>
        /// <returns>The SQL statement for creating the Awards table.</returns>
        public static string AwardTable()
        {
            return @"CREATE TABLE IF NOT EXISTS Awards (
                AwardId INTEGER PRIMARY KEY AUTOINCREMENT,
                MovieId INTEGER NOT NULL,
                AwardName TEXT NOT NULL,
                Category TEXT NOT NULL,
                Year INTEGER NOT NULL,
                Won INTEGER NOT NULL DEFAULT 0,
                FOREIGN KEY (MovieId) REFERENCES Movies (MovieId) ON DELETE CASCADE
            );";
        }

        /// <summary>
        /// Returns the SQL statement required to create the 'Summaries' table if it does not already exist.
        /// </summary>
        /// <returns>A string containing the SQL 'CREATE TABLE' statement for the 'Summaries' table, including columns for 'Id'
        /// and 'Year'.</returns>
        public static string SummaryTable()
        {
            return @"CREATE TABLE IF NOT EXISTS Summaries (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Year INTEGER NOT NULL UNIQUE
            );";
        }

        /// <summary>
        /// Generates the SQL statement for creating the SummaryMovies junction table.
        /// </summary>
        /// <returns>The SQL statement for creating the SummaryMovies table.</returns>
        public static string SummaryMoviesTable()
        {
            return @"CREATE TABLE IF NOT EXISTS SummaryMovies (
                SummaryId INTEGER NOT NULL,
                MovieId INTEGER NOT NULL,
                PRIMARY KEY (SummaryId, MovieId),
                FOREIGN KEY (SummaryId) REFERENCES Summaries(Id) ON DELETE CASCADE,
                FOREIGN KEY (MovieId) REFERENCES Movies(MovieId) ON DELETE CASCADE
            );";
        }

        /// <summary>
        /// Generates SQL statements to create indexes on various tables to optimize query performance.
        /// </summary>
        /// <returns>The SQL statements for creating indexes on various tables.</returns>
        public static string CreateIndexes()
        {
            return @"
                CREATE INDEX IF NOT EXISTS idx_movies_title ON Movies(Title);
                CREATE INDEX IF NOT EXISTS idx_movies_releaseyear ON Movies(ReleaseYear);
                CREATE INDEX IF NOT EXISTS idx_movies_genre ON Movies(Genre);
                CREATE INDEX IF NOT EXISTS idx_awards_movieid ON Awards(MovieId);
                CREATE INDEX IF NOT EXISTS idx_summaries_year ON Summaries(Year);
                CREATE INDEX IF NOT EXISTS idx_summarymovies_summaryid ON SummaryMovies(SummaryId);
                CREATE INDEX IF NOT EXISTS idx_summarymovies_movieid ON SummaryMovies(MovieId);
            ";
        }
    }
}