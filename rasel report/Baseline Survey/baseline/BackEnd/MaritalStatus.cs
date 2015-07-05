using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class MaritalStatus
    {
        private String maritalstatus;
        private Database DB = new Database();
        public String getMaritalStatus(int maritalstatusno)
        {
            String s = "SELECT status FROM marital_status WHERE marital_no =" + maritalstatusno + "";
            maritalstatus = DB.SelectSrting(s);
            return maritalstatus;
        }
    }
}
