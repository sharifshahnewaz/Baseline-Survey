using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace BackEnd
{
    public class Cnc
    {
        private Database DB = new Database();
        public  bool exist(String cncid)
        {
            String s = "select count(cnc_id) from cnc where cnc_id='" + cncid + "'";
            int no = DB.SelectInt(s);
            if (no == 1)
                return true;
            else
                return false;
        }
        public  bool insert(int cncno,String cncid,string unionid)
        {
            String s = "INSERT INTO cnc (cnc_no, union_id, cnc_id) VALUES ("+cncno+",'"+unionid+"','"+cncid+"')";
            bool inserted = DB.Insert(s);
            return inserted;
        }

    }
}
