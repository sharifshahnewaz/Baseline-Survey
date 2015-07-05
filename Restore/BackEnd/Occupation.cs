using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class Occupation
    {
        private String occupation;
        private Database DB = new Database();
        public String getOccupation(int occupationno)
        {
            String s = "SELECT occupation FROM occupation WHERE occupation_no =" + occupationno + "";
            occupation = DB.SelectSrting(s);
            return occupation;
        }
    }
}
