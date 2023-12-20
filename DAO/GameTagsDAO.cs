using EpistWinform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpistWinform.DAO
{
    public class GameTagsDAO
    {
        private static GameTagsDAO instance;

        public static GameTagsDAO Instance
        {
            get { if (instance == null) instance = new GameTagsDAO(); return GameTagsDAO.instance; }
            private set { instance = value; }   
        }

        private GameTagsDAO() { }

        public List<GameTags> LoadGameTagsList()
        {
            List<GameTags> gameTagsLists = new List<GameTags>();

            string query = "GetGameTagsList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                GameTags gameTags = new GameTags(row);
                gameTagsLists.Add(gameTags);
            }

            return gameTagsLists;
        }
    }
}