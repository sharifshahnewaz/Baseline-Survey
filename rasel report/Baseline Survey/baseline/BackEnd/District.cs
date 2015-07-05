using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BackEnd
{
    public class District
    {
        private String distrintname = null;
        private Database DB = new Database();
        private int districtno;
        public String getDistrictName(int districtno)
        {
            String s = "SELECT district_name FROM  district WHERE district_no = " + districtno + "";
            distrintname = DB.SelectSrting(s);
            return distrintname;
        }

        public string[]  getDistrictList()
        {
            
            String s = "SELECT DISTINCT district_name FROM district";
            //MessageBox.Show(s);
            String[] ret=DB.SelectSingleColumn(s,"district");            
            return ret;
            
        }
        public int getDistrictNo(String districtname)
        {
            String s = "SELECT district_no FROM  district WHERE district_name = '"+districtname+"'";
            int distrintno = DB.SelectInt(s);
            return distrintno; 
        }
        
    }
}
