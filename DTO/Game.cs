using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpistWinform.DTO
{
    public class Game
    {
        private int gameID;
        public int GameID { get => gameID; set => gameID = value; }

        private string gameName;
        public string GameName { get => gameName; set => gameName = value; }

        private string gameInfo;
        public string GameInfo { get => gameInfo; set => gameInfo = value; }

        private string picture1;
        public string Picture1 { get => picture1; set => picture1 = value; }

        private string picture2;
        public string Picture2 { get => picture2; set => picture2 = value; }
        
        private string picture3;
        public string Picture3 { get => picture3; set => picture3 = value; }

        public Game(int gameID = 0, string gameName = "", string gameInfo = "", string picture1 = "", string picture2 = "", string picture3 = "")
        {
            this.gameID = gameID;
            this.gameName = gameName;
            this.gameInfo = gameInfo;
            this.picture1 = picture1;
            this.picture2 = picture2;
            this.picture3 = picture3;
        }

        public Game(DataRow row)
        {
            this.gameID = (int)row["gameID"];
            this.gameName = row["gameName"].ToString();
            this.gameInfo = row["gameInfo"].ToString();
            this.picture1 = row["picture1"].ToString();
            this.picture2 = row["picture2"].ToString();
            this.picture3 = row["picture3"].ToString();
        }

    }
}
