using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public  class Sex
    {
        private String sex;
        private Database DB = new Database();
        public String getSex(int sexno)
        {
            String s = "SELECT sex FROM sex WHERE sex_no =" + sexno + "";
            sex = DB.SelectSrting(s);
            return sex;
        }
    }
}
