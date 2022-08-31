using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogo
{
    public class User
    {
        public int ID;
        public string name;

        public int tempID;
        public string tempName;

        public User() 
        {
            ID = 0;
            tempID = 0;
            name = "Player";
            tempName = "Player";
        }
        public string getCurrentName()
        {
            string result = "";
            Connection c = new Connection();
            string cmd = $"SELECT name from translations.user where id = 1";
            result = c.GetQueryTextField(c.Conn, cmd);
            return result;
        }
        /*
        public void updateUsername(string n) 
        {
            local.user = new User();
            local.user.name = n;
            Connection c = new Connection();
            string query = $"delete From user where id = 1;";
            c.SendQueryToDB(c.Conn, query);
            query = $"INSERT INTO translations.user VALUES(1,'{local.user.name}');";
            c.SendQueryToDB(c.Conn, query);
        }*/
    }
}
