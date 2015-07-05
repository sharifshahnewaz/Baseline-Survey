using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackEnd
{
    public  class Member
    {
        private Database DB = new Database();

        public bool Insert(
            String memberid,
            int memberno,
            int motherno,
            String name,
            int relationno,
            float age,
            String dob,
            int sexno,
            int maritalno,
            int maritalyear,
            int educationno,
            float weight,
            int height,
            int parity,
            int occupationno,
            String khanaid)
        {            
            String s = "INSERT INTO member (member_id,member_no, mother_no, name, relation_no, age, dob, sex_no, marital_no, marital_year, "+
                        "education_no, weight, height, parity, occupation_no, khana_id) "+
                        "VALUES ('" +memberid+"',"+ memberno + "," + motherno + ",'" + name + "'," + relationno + "," + age + 
                        ",'" + dob + "'," + sexno + "," + maritalno + "," + maritalyear + "," + educationno + "," + weight + 
                        "," + height + "," + parity + "," + occupationno + ",'" + khanaid + "')";
            //MessageBox.Show(s);
            
            bool inserted=DB.Insert(s);
            return inserted;
        }

        public String[,] getAll(String khanaid)
        {
            String s = "SELECT member_no, mother_no, name, relation_no, age, dob, sex_no, marital_no, marital_year, education_no, occupation_no, weight, height, parity FROM  member WHERE khana_id = '" + khanaid + "'";
            String[,] ret = DB.SelectColumns(s, "member");
            return ret;
        }
        public bool delete(String khanaid)
        {
            String s = "DELETE FROM member WHERE khana_id = '"+khanaid+"'";
            bool deleted = DB.Insert(s);
            return deleted;
 
        }
    }
    
}
