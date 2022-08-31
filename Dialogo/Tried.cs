using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogo
{
    public class Tried
    {
        public int seen;
        public int unseen;
        public int allSeenTrue;
        public string user;

        public int tempInt;
        public string tempStr;

        public Tried() 
        {
            seen = 0;
            unseen = 0;
            allSeenTrue = 0;
            user = "";
            tempInt = 0;
            tempStr = "";
        }
        public int getCurrentIntColVal(string col)
        {
            Connection c = new Connection();
            string cmd = $"SELECT {col} from translations.tried where id = 1";
            this.tempInt = c.GetIntQuery(c.Conn, cmd);
            return this.tempInt;
        }
        public string getCurrentStringColVal(string col)
        {
            Connection c = new Connection();
            string cmd = $"SELECT {col} from translations.tried where id = 1";
            this.tempStr = c.GetQueryTextField(c.Conn, cmd);
            return this.tempStr;
        }
        public void updateCurrentIntCol(string col, int val)
        {
            Connection c = new Connection();
            string cmd = $"Update translations.tried SET {col} = {val} where id = 1";
            c.GetIntQuery(c.Conn, cmd);
        }
        public void updateCurrentStrCol(string col, string val)
        {
            Connection c = new Connection();
            string cmd = $"Update translations.tried SET {col} = '{val}' where id = 1";
            c.GetIntQuery(c.Conn, cmd);
        }
        public void updateSeenAmount()
        {
            Connection c = new Connection();
            string query = $"SELECT Count(totalAns) from translations.words where totalAns > 0";
            this.seen = c.GetIntQuery(c.Conn, query);
            updateCurrentIntCol("seen", seen);
        }
 
        public void updateUnseenAmount()
        {
            int seen = getCurrentIntColVal("seen");
            updateCurrentIntCol("unseen", (1000-seen));
        }

        public void updateAllSeen() 
        { 
            updateCurrentIntCol("allSeenTrue", 1); 
        }
        public void DisplayData()
        {
            Console.WriteLine($"{this.seen},{this.unseen},{this.allSeenTrue},{this.user}");
        }
    }
}
