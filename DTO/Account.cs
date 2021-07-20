using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.DTO
{
    public class Account
    {
        public Account(string usename, string displayname, int type, string passwork = null)
        {
            this.Usename = usename;
            this.Displayname = displayname;
            this.Type = type;
            this.Passwork = passwork;

        }
        public Account(DataRow row)
        {
            this.Usename = row["usename"].ToString();
            this.Displayname = row["displayname"].ToString();
            this.Type = (int)row["type"];
            this.Passwork = row["passwork"].ToString();
        }
        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        private string passwork;
        public string Passwork
        {
            get { return passwork; }
            set { passwork = value; }
        }
        private string displayname;
        public string Displayname
        {
            get { return displayname; }
            set { displayname = value; }
        }
        private string usename;
        public string Usename
        {
            get { return usename; }
            set { usename = value; }
        }
    }
}
