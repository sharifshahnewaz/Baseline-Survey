using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class Village
    {
        private String villagename;
        private int unionno;
        private Database DB = new Database();
        public string[] getVillageList(int unionno)
        {
            String s = "SELECT village_name FROM [village],[union] where [village].union_no=[union].union_no and [village].union_no=" + unionno + "";
            //MessageBox.Show(s);
            String[] ret = DB.SelectSingleColumn(s, "village");
            return ret;
        }
    }
}
