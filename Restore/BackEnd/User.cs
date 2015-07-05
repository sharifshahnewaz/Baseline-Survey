using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BackEnd
{
    public class User
    {
        private String userId;
        private String password;
        private Database db = new Database();
        
        public String getPassword(String userId)
        {
            String ret = null;
            String s = "select password from [user] where user_id='" + userId + "'";
            //MessageBox.Show(s);
            ret = db.SelectSrting(s);
            return ret;
        }
        public String getName(String userId)
        {
            String ret = null;
            String s = "select name from [user] where user_id='" + userId + "'";
            //MessageBox.Show(s);
            ret = db.SelectSrting(s);
            return ret;
        }
        public int getMemberCount(String userId)
        {
            int ret = 0;
            String s = "select member_count from [user] where user_id='" + userId + "'";
            //MessageBox.Show(s);
            ret = db.SelectInt(s);
            return ret;
        }
        public void increaseMemberCount(String userId)
        {
            int x = getMemberCount(userId)+1;
            String s = "update [user] set member_count = "+x+" where user_id='" + userId + "'";
            //MessageBox.Show(s);
            db.Insert(s);
            
        }
        public void increaseKhanaCount(String userId)
        {
            int x = getKhanaCount(userId) + 1;
            String s = "update [user] set khana_count = " + x + " where user_id='" + userId + "'";
            //MessageBox.Show(s);
            db.Insert(s);

        }
        public int getKhanaCount(String userId)
        {
            int ret = 0;
            String s = "select khana_count from [user] where user_id='" + userId + "'";
            //MessageBox.Show(s);
            ret = db.SelectInt(s);
            return ret;
        }

       
    }
}
