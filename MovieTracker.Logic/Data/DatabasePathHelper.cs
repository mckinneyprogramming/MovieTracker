namespace MovieTracker.Logic.Data
{
    /// <summary>
    /// The helper class for retrieving the database path.
    /// </summary>
    public static class DatabasePathHelper
    {
        /// <summary>
        /// Retrieves the database path.
        /// </summary>
        /// <returns>The database path and database name.</returns>
        public static string GetDatabasePath()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "SQLite Databases",
                "MovieTracker.db");
        }
    }
}