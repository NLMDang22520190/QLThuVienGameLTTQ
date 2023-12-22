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
        private string tagDescription;

        public int TagID { get => tagID; set => tagID = value; }
        public string TagName { get => tagName; set => tagName = value; }
        public string TagDescription { get => tagDescription; set => tagDescription = value; }

        public Tag(int tagID, string tagName, string tagDescription)
        {
            this.tagID = tagID;
            this.tagName = tagName;
            this.tagDescription = tagDescription;
        }

        public Tag() { }

        public Tag(DataRow row)
        {
            this.tagID = (int)row["tagID"];
            this.tagName = row["tagName"].ToString();
            this.TagDescription = row["tagDecription"].ToString();
        }
    }
}
