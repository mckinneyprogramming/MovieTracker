namespace MovieTracker.Logic.Data
{
    /// <summary>
    /// Provides SQL query strings for database operations.
    /// </summary>
    public static class QueryStrings
    {
        #region Movie Queries

        public const string InsertMovie = @"
            INSERT INTO Movies (Title, ReleaseYear, Director, TopActor, Genre, Series, Runtime, Description,
                IsNationalFilmRegistry, IsDisney, NationalFilmRegistryYear, IsWatched, FirstWatch, 
                WatchedDate, UserRating, Notes, DateAdded)
            VALUES (@Title, @ReleaseYear, @Director, @TopActor, @Genre, @Series, @Runtime, @Description,
                @IsNationalFilmRegistry, @IsDisney, @NationalFilmRegistryYear, @IsWatched, @FirstWatch,
                @WatchedDate, @UserRating, @Notes, @DateAdded);
            SELECT last_insert_rowid();";

        public const string UpdateMovie = @"
            UPDATE Movies
            SET Title = @Title, ReleaseYear = @ReleaseYear, Director = @Director, TopActor = @TopActor,
                Genre = @Genre, Series = @Series, Runtime = @Runtime, Description = @Description,
                IsNationalFilmRegistry = @IsNationalFilmRegistry, IsDisney = @IsDisney,
                NationalFilmRegistryYear = @NationalFilmRegistryYear, IsWatched = @IsWatched,
                FirstWatch = @FirstWatch, WatchedDate = @WatchedDate, UserRating = @UserRating,
                Notes = @Notes
            WHERE MovieId = @MovieId;";

        public const string DeleteMovie = "DELETE FROM Movies WHERE MovieId = @MovieId;";

        public const string GetMovieById = "SELECT * FROM Movies WHERE MovieId = @MovieId;";

        public const string GetAllMovies = "SELECT * FROM Movies ORDER BY Title;";

        public const string SearchMoviesByTitle = "SELECT * FROM Movies WHERE Title LIKE @SearchTerm ORDER BY Title;";

        public const string GetWatchedMovies = "SELECT * FROM Movies WHERE IsWatched = 1 ORDER BY WatchedDate DESC;";

        public const string GetMoviesByGenre = "SELECT * FROM Movies WHERE Genre = @Genre ORDER BY Title;";

        public const string GetDisneyMovies = "SELECT * FROM Movies WHERE IsDisney = 1 ORDER BY Title;";

        public const string GetNationalFilmRegistryMovies = "SELECT * FROM Movies WHERE IsNationalFilmRegistry = 1 ORDER BY Title;";

        public const string GetUnwatchedMovies = "SELECT * FROM Movies WHERE IsWatched = 0 ORDER BY Title;";

        public const string GetMoviesByReleaseYearRange = "SELECT * FROM Movies WHERE ReleaseYear IS NOT NULL AND ReleaseYear >= @YearFrom AND ReleaseYear <= @YearTo ORDER BY Title;";

        public const string GetMoviesByAwardName = @"
            SELECT DISTINCT m.* FROM Movies m
            INNER JOIN Awards a ON m.MovieId = a.MovieId
            WHERE a.AwardName = @AwardName
            ORDER BY m.Title;";

        public const string GetDistinctReleaseYears = "SELECT DISTINCT ReleaseYear FROM Movies WHERE ReleaseYear IS NOT NULL ORDER BY ReleaseYear;";

        #endregion

        #region Award Queries

        public const string InsertAward = @"
            INSERT INTO Awards (MovieId, AwardName, Category, Year, Won)
            VALUES (@MovieId, @AwardName, @Category, @Year, @Won);
            SELECT last_insert_rowid();";

        public const string UpdateAward = @"
            UPDATE Awards
            SET MovieId = @MovieId, AwardName = @AwardName, Category = @Category, 
                Year = @Year, Won = @Won
            WHERE AwardId = @AwardId;";

        public const string DeleteAward = "DELETE FROM Awards WHERE AwardId = @AwardId;";

        public const string GetAwardsByMovieId = "SELECT * FROM Awards WHERE MovieId = @MovieId ORDER BY Year DESC;";

        public const string GetAwardsWon = "SELECT * FROM Awards WHERE Won = 1 ORDER BY Year DESC;";

        public const string GetDistinctAwardNames = "SELECT DISTINCT AwardName FROM Awards ORDER BY AwardName;";

        public const string GetCategoriesByAwardName = "SELECT DISTINCT Category FROM Awards WHERE AwardName = @AwardName ORDER BY Category;";

        #endregion

        #region Summary Queries

        public const string InsertSummary = @"
            INSERT INTO Summaries (Year)
            VALUES (@Year);
            SELECT last_insert_rowid();";

        public const string DeleteSummary = "DELETE FROM Summaries WHERE Id = @Id;";

        public const string GetSummaryById = "SELECT * FROM Summaries WHERE Id = @Id;";

        public const string GetSummaryByYear = "SELECT * FROM Summaries WHERE Year = @Year;";

        public const string GetAllSummaries = "SELECT * FROM Summaries ORDER BY Year DESC;";

        public const string AddMovieToSummary = @"
            INSERT OR IGNORE INTO SummaryMovies (SummaryId, MovieId)
            VALUES (@SummaryId, @MovieId);";

        public const string RemoveMovieFromSummary = "DELETE FROM SummaryMovies WHERE SummaryId = @SummaryId AND MovieId = @MovieId;";

        public const string GetMoviesBySummaryId = @"
            SELECT m.*
            FROM Movies m
            INNER JOIN SummaryMovies sm ON m.MovieId = sm.MovieId
            WHERE sm.SummaryId = @SummaryId
            ORDER BY m.Title;";

        public const string GetSummaryCount = "SELECT COUNT(*) FROM Summaries;";

        #endregion
    }
}