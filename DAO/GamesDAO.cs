using EpistWinform.DTO;
using EpistWinform.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpistWinform.DAO
{
    public class GamesDAO
    {
        private static GamesDAO instance;

        public static GamesDAO Instance
        {
            get { if (instance == null) instance = new GamesDAO(); return GamesDAO.instance; }
            private set { GamesDAO.instance = value; }
        }

        public List<Game> ListAllGames
        {
            get { if (listAllGames.Count <= 0) listAllGames = LoadGamesList(); return listAllGames; }
        }

        private List<Game> listAllGames = new List<Game>();

        private List<Game> listOwnGames = new List<Game>();


        private GamesDAO() { }

        public List<Game> LoadGamesList()
        {
            List<Game> gameList = new List<Game>();

            string querry = "GetGameList";

            DataTable data = DataProvider.Instance.ExecuteQuery(querry);
            foreach (DataRow row in data.Rows)
            {
                Game game = new Game(row);
                gameList.Add(game);
            }

            return gameList;
        }

        public List<Game> LoadOwnGamesList(int userID)
        {
            if (listOwnGames.Count <= 0)
            {
                List<Game> gameList = new List<Game>();

                string querry = "GetOwnGameList @userID";

                DataTable data = DataProvider.Instance.ExecuteQuery(querry, new object[] { userID });
                foreach (DataRow row in data.Rows)
                {
                    Game game = new Game(row);
                    gameList.Add(game);
                }
                listOwnGames = gameList;
            }


            return listOwnGames;
        }

        public bool InsertGame(string gameName, string gameInfo, string picture1, string picture2, string picture3)
        {

            string query = $"INSERT dbo.Game (gameName, gameInfo, picture1, picture2, picture3) VALUES ( @gameName , @gameInfo , @picture1 , @picture2 , @picture3 )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {gameName, gameInfo, picture1, picture2, picture3});
            return result > 0;
        }

        public bool EditGame(int gameID, string newGameName, string newGameInfo)
        {
            string query = "UPDATE dbo.Game SET gameName = @newGameName , gameInfo = @newGameInfo WHERE gameID = @gameID ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { newGameName, newGameInfo, gameID });
            return result > 0;
        }















        public bool InsertGameToOwnedGames(int gameID, int userID)
        {
            string query = string.Format("INSERT dbo.OwnedGame ( gameID, userID) VALUES ({0}, {1})", gameID, userID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool IsGameInOwnedGames(int gameID, int userID)
        {
            string query = string.Format("SELECT COUNT(*) FROM OwnedGame WHERE gameID = {0} AND userID = {1}", gameID, userID);

            // Use ExecuteScalar to retrieve the count
            object result = DataProvider.Instance.ExecuteScalar(query);

            // If result is not null and can be converted to an integer, check if it's greater than 0
            if (result != null && int.TryParse(result.ToString(), out int count))
            {
                return count > 0;
            }

            // If there's an issue with the query or conversion, return false
            return false;
        }


    }
}