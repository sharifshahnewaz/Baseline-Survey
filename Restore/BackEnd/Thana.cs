using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BackEnd
{
    public class Thana
    {
        private String thananame = null;
        private int thanano;
        private int districtno;
        private Database DB = new Database();

        public string[] getThanaList(int districtno)
        {
            String s = "SELECT thana_id FROM thana,district where thana.district_no=district.district_no and thana.district_no="+districtno+"";     
            //MessageBox.Show(s);
            
            String[] id = DB.SelectSingleColumn(s, "thana");
            String[] ret= new String[id.Length];
            for (int i = 0; i < id.Length; i++)
            {
                ret[i] = getThanaName(id[i]);
            }
                return ret;
        }
        
        public String getThanaName(int thanano, int districtno)
        {
            String s = "SELECT thana_name FROM thana,district where thana.district_no=district.district_no and thana.district_no=" + districtno + " and thana.thana_no="+thanano+"";
            thananame = DB.SelectSrting(s);
            return thananame;
        }
        public int getThanaNo(String thananame,int districtno)
        {
            String s = "SELECT thana_no FROM thana,district where thana.district_no=district.district_no and thana.district_no=" + districtno + " and thana.thana_name='" + thananame + "'";
            int distrintno = DB.SelectInt(s);
            return distrintno;
        }
        public int getThanaNo(String thanaID)
        {
            String s = "SELECT thana_no FROM thana where thana_id='"+thanaID+"'";
            int distrintno = DB.SelectInt(s);
            return distrintno;
        }
        public String getThanaName(String thanaID)
        {
            String s = "SELECT thana_name FROM thana where thana_id='" + thanaID + "'";
            thananame = DB.SelectSrting(s);
            return thananame;
        }

        public String generateThanaID(int districtno,int thanano)
        {
            String s = "D"+districtno+"T"+thanano+"";
            return s;
        }
    }
}
