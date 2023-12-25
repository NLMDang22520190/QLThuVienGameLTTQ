using EpistWinform.DTO;
using EpistWinform.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public bool InsertGameTags(int gameID, List<int> selectedTagID)
        {
            // Tạo câu lệnh SQL
            string query = "INSERT INTO GameTags (gameID, tagID) VALUES ";

            // Tạo danh sách các giá trị (gameID, tagID)
            List<string> values = new List<string>();
            foreach (int tagID in selectedTagID)
            {
                values.Add($"({gameID}, {tagID})");
            }

            // Ghép các giá trị vào câu lệnh SQL
            query += string.Join(", ", values);
            MessageBox.Show(query);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


    }
}