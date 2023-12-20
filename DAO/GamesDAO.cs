using EpistWinform.DTO;
using EpistWinform.Forms;
using System;
using System.Collections.Generic;
using System.Data;
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
            List<Game> gameList = new List<Game>();

            string querry = "GetOwnGameList @userID";

            DataTable data = DataProvider.Instance.ExecuteQuery(querry, new object[] {userID});
            foreach (DataRow row in data.Rows)
            {
                Game game = new Game(row);
                gameList.Add(game);
            }

            return gameList;
        }

        public bool InsertGame(string gameName, string gameInfo, string picture1, string picture2, string picture3)
        {

            string query = string.Format($"INSERT dbo.Game ( gameName, gameInfo, picture1, picture2, picture3) VALUES (N'{0}', {1}, {2}, N'{3}', N'{4}', N'{5}')", gameName, gameInfo, picture1, picture2, picture3);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}