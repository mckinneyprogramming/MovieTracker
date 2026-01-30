using Microsoft.Data.Sqlite;
using MovieTracker.Logic.Models;

namespace MovieTracker.Logic.Data.Repositories
{
    /// <summary>
    /// Handles database operations for Award entities.
    /// </summary>
    public class AwardRepository
    {
        private readonly string _connectionString;

        public AwardRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Insert(Award award)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.InsertAward;

            DataParameters.AddAwardParameters(command, award);

            var result = command.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        public int Update(Award award)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.UpdateAward;

            command.Parameters.AddWithValue("@AwardId", award.AwardId);
            DataParameters.AddAwardParameters(command, award);

            return command.ExecuteNonQuery();
        }

        public int Delete(int awardId)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.DeleteAward;
            command.Parameters.AddWithValue("@AwardId", awardId);

            return command.ExecuteNonQuery();
        }

        public List<Award> GetByMovieId(int movieId)
        {
            var awards = new List<Award>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetAwardsByMovieId;
            command.Parameters.AddWithValue("@MovieId", movieId);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                awards.Add(DataMapper.MapAward(reader));
            }

            return awards;
        }

        public List<Award> GetAwardsWon()
        {
            var awards = new List<Award>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = QueryStrings.GetAwardsWon;

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                awards.Add(DataMapper.MapAward(reader));
            }

            return awards;
        }
    }
}