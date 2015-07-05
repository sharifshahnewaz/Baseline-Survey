using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class Union
    {
        private String unionname;
        private int unionno;
        private int thanano;
        private Database DB = new Database();
        public string[] getUnionList(String thanaid)
        {
            String s = "SELECT union_id FROM [union],thana where [union].thana_id=thana.thana_id and [union].thana_id='" + thanaid + "'";
            //MessageBox.Show(s);
            String[] st = DB.SelectSingleColumn(s, "union");
            String [] ret = new String[st.Length];
            for (int i = 0; i < st.Length; i++)
            {
                ret[i] = getUnionName(st[i]);
            }
                return ret;
        }
        public String getUnionName(int unionno, int thanano)
        {
            String s = "SELECT union_name FROM [union],thana where [union].thana_no=thana.thana_no and [union].thana_no=" + thanano + " and [union].union_no=" + unionno + "";
            unionname = DB.SelectSrting(s);
            return unionname;
        }
        public int getUnionNo(String unionname, String thanaid)
        {
            String s = "SELECT union_no FROM [union],thana where [union].thana_id=thana.thana_id and [union].thana_id='" + thanaid + "' and [union].union_name='" + unionname + "'";
            int unionno = DB.SelectInt(s);
            return unionno;
        }
        public String getUnionName(String unionid)
        {
            String s = "SELECT union_name FROM [union]where [union].union_id='" + unionid + "'";
            unionname = DB.SelectSrting(s);
            return unionname;
        }
        public String generateUnionID(int districtid,int thanaid, int unionno)
        {
            String s = "D"+districtid+"T" + thanaid + "U" + unionno + "";
            return s;
        }

    }
}
