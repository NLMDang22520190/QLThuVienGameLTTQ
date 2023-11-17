﻿using EpistWinform.DTO;
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

            DataTable data = DataProvider.Instance.ExecuteQuery("GetGameList");
            foreach (DataRow row in data.Rows)
            {
                Game game = new Game(row);
                gameList.Add(game);
            }

            return gameList;
        }
    }
}
