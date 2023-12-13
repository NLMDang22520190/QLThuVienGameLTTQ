using EpistWinform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpistWinform.DAO
{
    public class TagDAO
    {
        private static TagDAO instance;

        public static TagDAO Instance
        {
            get { if (instance == null) instance = new TagDAO(); return TagDAO.instance; }
            private set { instance = value; }   
        }

        private TagDAO() { }

        public List<Tag> LoadTagsList()
        {
            List<Tag> tagList = new List<Tag>();

            string querry = "GetTagList";

            DataTable data = DataProvider.Instance.ExecuteQuery(querry);
            foreach (DataRow row in data.Rows)
            {
                Tag tag = new Tag(row);
                tagList.Add(tag);
            }

            return tagList;
        }

    }


}
