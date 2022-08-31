using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogo
{
   public static class local
    {
        public static int amount { get; set; }
        public static int amountMAX { get; set; }
        public static int correctAnswers;
        public static int incorrectAnswers;
        public static int filterIndex { get; set; }        
        public static string wordFilter { get; set; }
        public static BindingList <int> searchWordIDs;  
        public static Word word;
        public static Tried data;
        public static User user;
    }
}
