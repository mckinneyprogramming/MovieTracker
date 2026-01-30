using Microsoft.Data.Sqlite;
using MovieTracker.Logic.Models;

namespace MovieTracker.Logic.Data.Repositories
{
    /// <summary>
    /// Handles database operations for Summary entities.
    /// </summary>
    public class SummaryRepository
    {
        private readonly string _connectionString;

        public SummaryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Insert(Summary summary)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.InsertSummary;
            command.Parameters.AddWithValue("@Year", summary.Year);

            var result = command.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        public int Delete(int id)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.DeleteSummary;
            command.Parameters.AddWithValue("@Id", id);

            return command.ExecuteNonQuery();
        }

        public Summary? GetById(int id, MovieRepository movieRepository, AwardRepository awardRepository)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetSummaryById;
            command.Parameters.AddWithValue("@Id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var summary = new Summary
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Year = reader.GetInt32(reader.GetOrdinal("Year")),
                    Movies = []
                };
                reader.Close();
                summary.Movies = GetMoviesBySummaryId(id, awardRepository);
                return summary;
            }

            return null;
        }

        public Summary? GetByYear(int year, MovieRepository movieRepository, AwardRepository awardRepository)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetSummaryByYear;
            command.Parameters.AddWithValue("@Year", year);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var id = reader.GetInt32(reader.GetOrdinal("Id"));
                var summary = new Summary
                {
                    Id = id,
                    Year = reader.GetInt32(reader.GetOrdinal("Year")),
                    Movies = []
                };
                reader.Close();
                summary.Movies = GetMoviesBySummaryId(id, awardRepository);
                return summary;
            }

            return null;
        }

        public List<Summary> GetAll(MovieRepository movieRepository, AwardRepository awardRepository)
        {
            var summaries = new List<Summary>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetAllSummaries;

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(reader.GetOrdinal("Id"));
                summaries.Add(new Summary
                {
                    Id = id,
                    Year = reader.GetInt32(reader.GetOrdinal("Year")),
                    Movies = []
                });
            }
            reader.Close();

            foreach (var summary in summaries)
            {
                summary.Movies = GetMoviesBySummaryId(summary.Id, awardRepository);
            }

            return summaries;
        }

        public void AddMovieToSummary(int summaryId, int movieId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.AddMovieToSummary;
            command.Parameters.AddWithValue("@SummaryId", summaryId);
            command.Parameters.AddWithValue("@MovieId", movieId);

            command.ExecuteNonQuery();
        }

        public int RemoveMovieFromSummary(int summaryId, int movieId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.RemoveMovieFromSummary;
            command.Parameters.AddWithValue("@SummaryId", summaryId);
            command.Parameters.AddWithValue("@MovieId", movieId);

            return command.ExecuteNonQuery();
        }

        private List<Movie> GetMoviesBySummaryId(int summaryId, AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetMoviesBySummaryId;
            command.Parameters.AddWithValue("@SummaryId", summaryId);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                movies.Add(DataMapper.MapMovie(reader));
            }
            reader.Close();

            foreach (var movie in movies)
            {
                movie.Awards = awardRepository.GetByMovieId(movie.MovieId);
            }

            return movies;
        }
    }
}