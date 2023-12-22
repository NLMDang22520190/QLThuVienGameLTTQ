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

            string query = "GetTagList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow row in data.Rows)
            {
                Tag tag = new Tag(row);
                tagList.Add(tag);
            }

            return tagList;
        }

        private List<Tag> allTagsList = new List<Tag>();
        public List<Tag> AllTagsList
        {
            get 
            {
                if (allTagsList.Count <= 0) allTagsList = LoadTagsList();
                return allTagsList; 
            }
        }

        public bool AddTag(int tagID, string tagName, string tagDescripstion)
        {
            string query = string.Format("INSERT dbo.Tags (tagID, tagName, tagDecription) VALUES ({0}, N'{1}', N'2')", tagID, tagName, tagDescripstion);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
