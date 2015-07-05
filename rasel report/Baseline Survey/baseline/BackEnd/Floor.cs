using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class Floor
    {
        private String floor;
        private Database DB = new Database();
        public String getFloor(int floorno)
        {
            String s = "SELECT floor FROM floor WHERE floor_no =" + floorno + "";
            floor = DB.SelectSrting(s);
            return floor;
        }
    }
}
