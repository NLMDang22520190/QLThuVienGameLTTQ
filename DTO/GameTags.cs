using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpistWinform.DTO
{
    public class GameTags
    {
        private int gameID;
        private int tagID;

        public int GameID { get => gameID; set => gameID = value; }
        public int TagID { get => tagID; set => tagID = value; }

        public Game Game { get; set; }

        public GameTags() { }

        public GameTags(int gameID, int tagID)
        {
            this.gameID = gameID;
            this.tagID = tagID;
        }

        public GameTags(DataRow row)
        {
            this.gameID = (int)row["gameID"];
            this.tagID = (int)row["tagID"];
        }
    }
}
