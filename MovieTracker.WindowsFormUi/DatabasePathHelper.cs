namespace MovieTracker.WindowsFormUi
{
    /// <summary>
    /// Provides the database path from configuration. Reads from the
    /// MOVIETRACKER_DATABASE_PATH environment variable when set;
    /// otherwise uses a default path so the app works without configuration.
    /// </summary>
    public static class DatabasePathHelper
    {
        /// <summary>
        /// Environment variable name for the SQLite database file path.
        /// Set this to avoid hardcoding or exposing the path in the application.
        /// </summary>
        public const string DatabasePathEnvironmentVariable = "MOVIETRACKER_DATABASE_PATH";

        /// <summary>
        /// Gets the database path. Uses MOVIETRACKER_DATABASE_PATH if set and non-empty;
        /// otherwise returns the default path (Desktop\SQLite Databases\MovieTracker.db).
        /// </summary>
        public static string GetDatabasePath()
        {
            var path = Environment.GetEnvironmentVariable(DatabasePathEnvironmentVariable);
            if (!string.IsNullOrWhiteSpace(path))
            {
                return path.Trim();
            }

            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "SQLite Databases",
                "MovieTracker.db");
        }
    }
}
