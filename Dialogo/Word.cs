using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogo
{
    public class Word
    {
        public int ID { get; set; }
        public string ENG { get; set; }
        public string PTBR { get; set; }
        public int CorrectAns { get; set; }
        public int IncorrectAns { get; set; }
        public int TotalAns { get; set; }

        public Word()

        {
            ID = 0;
            ENG = "";
            PTBR = "";
            CorrectAns = 0;
            IncorrectAns = 0;
            TotalAns = CorrectAns + IncorrectAns;
        }
//---------------------------------------------------------------------------//
//---------------------------------------------------------------------------//
        public int getCurrentIntColByID(string col)
        {
            int val = 0; 
            Connection c = new Connection();
            string cmd = $"SELECT {col} from translations.words where id = {ID}";
            val = c.GetIntQuery(c.Conn, cmd);
            return val;
        }
        public string getCurrentStringColByID(string col)
        {
            string result = ""; 
            Connection c = new Connection();
            string cmd = $"SELECT {col} from translations.words where id = {ID}";
            result = c.GetQueryTextField(c.Conn, cmd);
            return result;
        }
//---------------------------------------------------------------------------//
//---------------------------------------------------------------------------//
        public void updateIncorrectIntColByID( int val)
        {          
            Connection c = new Connection();
            string cmd = $"Update translations.Words SET incorrectAns = {val} where id = {ID}";
            this.IncorrectAns = c.GetIntQuery(c.Conn, cmd);
        }
        public void updateCorrectIntColByID( int val)
        {        
            Connection c = new Connection();
            string cmd = $"Update translations.Words SET correctAns = {val} where id = {ID}";
            this.CorrectAns = c.GetIntQuery(c.Conn, cmd);
        }
        public void updateIntColByID(string col, int val)
        {
            Connection c = new Connection();
            string cmd = $"Update translations.Words SET {col} = {val} where id = {ID}";
            c.GetIntQuery(c.Conn, cmd);
        }
//---------------------------------------------------------------------------//
//---------------------------------------------------------------------------//

        public void DisplayData()
        {
            Console.WriteLine($"{this.ID},{this.ENG},{this.PTBR},{this.CorrectAns},{this.IncorrectAns},{this.TotalAns}");
        }

        public void incrementCorrectAns()
        {
            int val = getCurrentIntColByID("correctAns");
            updateCorrectIntColByID(val + 1);
        }
        public void incrementIncorrectAns()
        {
            int val = getCurrentIntColByID("incorrectAns");
            updateIncorrectIntColByID(val + 1);
        }
        public void updateTotalAns()
        {
            int val = getCurrentIntColByID("correctAns") + getCurrentIntColByID("incorrectAns");
            updateIntColByID("totalAns", val);
        }
        public void setAllKnown()
        {
            Connection c = new Connection();
            string cmd = "update translations.words set seen = 1 where seen = 0";
            c.SendQueryToDB(c.Conn, cmd);
        }

    }
    

}
