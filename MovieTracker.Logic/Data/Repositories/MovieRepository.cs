using Microsoft.Data.Sqlite;
using MovieTracker.Logic.Models;

namespace MovieTracker.Logic.Data.Repositories
{
    /// <summary>
    /// Handles database operations for Movie entities.
    /// </summary>
    public class MovieRepository
    {
        private readonly string _connectionString;

        public MovieRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Insert(Movie movie)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.InsertMovie;

            DataParameters.AddMovieParameters(command, movie);

            var result = command.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        public int Update(Movie movie)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.UpdateMovie;

            command.Parameters.AddWithValue("@MovieId", movie.MovieId);
            DataParameters.AddMovieParameters(command, movie);

            return command.ExecuteNonQuery();
        }

        public int Delete(int movieId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.DeleteMovie;
            command.Parameters.AddWithValue("@MovieId", movieId);

            return command.ExecuteNonQuery();
        }

        public Movie? GetById(int movieId, AwardRepository awardRepository)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetMovieById;
            command.Parameters.AddWithValue("@MovieId", movieId);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var movie = DataMapper.MapMovie(reader);
                reader.Close(); // Close reader before next query
                movie.Awards = awardRepository.GetByMovieId(movieId);
                return movie;
            }

            return null;
        }

        public List<Movie> GetAll(AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetAllMovies;

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                movies.Add(DataMapper.MapMovie(reader));
            }
            reader.Close();

            // Load awards for all movies
            foreach (var movie in movies)
            {
                movie.Awards = awardRepository.GetByMovieId(movie.MovieId);
            }

            return movies;
        }

        public List<Movie> SearchByTitle(string searchTerm, AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.SearchMoviesByTitle;
            command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

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

        public List<Movie> GetWatched(AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetWatchedMovies;

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

        public List<Movie> GetByGenre(string genre, AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetMoviesByGenre;
            command.Parameters.AddWithValue("@Genre", genre);

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

        public List<Movie> GetDisney(AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetDisneyMovies;

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

        public List<Movie> GetNationalFilmRegistry(AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetNationalFilmRegistryMovies;

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

        public List<Movie> GetUnwatched(AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetUnwatchedMovies;

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

        public List<Movie> GetByReleaseYearRange(int yearFrom, int yearTo, AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetMoviesByReleaseYearRange;
            command.Parameters.AddWithValue("@YearFrom", yearFrom);
            command.Parameters.AddWithValue("@YearTo", yearTo);

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

        public List<Movie> GetByAwardName(string awardName, AwardRepository awardRepository)
        {
            var movies = new List<Movie>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetMoviesByAwardName;
            command.Parameters.AddWithValue("@AwardName", awardName ?? string.Empty);

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

        /// <summary>
        /// Gets distinct release years from the database for use in filter dropdowns.
        /// </summary>
        public List<int> GetDistinctReleaseYears()
        {
            var years = new List<int>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetDistinctReleaseYears;

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                years.Add(reader.GetInt32(0));
            }

            return years;
        }
    }
}