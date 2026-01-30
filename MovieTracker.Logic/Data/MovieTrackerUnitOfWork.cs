using MovieTracker.Logic.Data.Repositories;
using MovieTracker.Logic.Queries;
using Microsoft.Data.Sqlite;

namespace MovieTracker.Logic.Data
{
    /// <summary>
    /// Coordinates database operations across multiple repositories and manages transactions.
    /// </summary>
    public class MovieTrackerUnitOfWork : IDisposable
    {
        private readonly string _connectionString;
        
        public MovieRepository Movies { get; }

        public AwardRepository Awards { get; }

        public SummaryRepository Summaries { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieTrackerUnitOfWork"/> class.
        /// </summary>
        /// <param name="databasePath">The full path to the SQLite database file.</param>
        public MovieTrackerUnitOfWork(string databasePath)
        {
            _connectionString = $"Data Source={databasePath}";
            
            Movies = new MovieRepository(_connectionString);
            Awards = new AwardRepository(_connectionString);
            Summaries = new SummaryRepository(_connectionString);
        }

        /// <summary>
        /// Initializes the database by creating all required tables and indexes.
        /// </summary>
        public void InitializeDatabase()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            ExecuteNonQuery(connection, TableCreator.MovieTable());
            ExecuteNonQuery(connection, TableCreator.AwardTable());
            ExecuteNonQuery(connection, TableCreator.SummaryTable());
            ExecuteNonQuery(connection, TableCreator.SummaryMoviesTable());
            ExecuteNonQuery(connection, TableCreator.CreateIndexes());
        }

        /// <summary>
        /// Executes multiple database operations within a single transaction.
        /// </summary>
        /// <param name="action">The action containing database operations to execute.</param>
        public void ExecuteTransaction(Action action)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();

            try
            {
                action();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Executes a non-query SQL command.
        /// </summary>
        /// <param name="connection">The SQLite connection.</param>
        /// <param name="sql">The SQL command text.</param>
        private static void ExecuteNonQuery(SqliteConnection connection, string sql)
        {
            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Disposes of the resources used by the unit of work.
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}