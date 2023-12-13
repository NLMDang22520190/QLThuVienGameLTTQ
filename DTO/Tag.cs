using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpistWinform.DTO
{
    public class Tag
    {
        private int tagID;
        private string tagName;

        public int TagID { get => tagID; set => tagID = value; }
        public string TagName { get => tagName; set => tagName = value; }

        public Tag(int tagID, string tagName)
        {
            this.tagID = tagID;
            this.tagName = tagName;
        }

        public Tag() { }

        public Tag(DataRow row)
        {
            this.tagID = (int)row["tagID"];
            this.tagName = row["tagName"].ToString();
        }
    }
}
