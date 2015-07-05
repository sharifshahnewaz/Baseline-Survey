using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public  class Wall
    {
        private String wall;
        private Database DB = new Database();
        public String getWall(int wallno)
        {
            String s = "SELECT wall FROM wall WHERE wall_no =" + wallno + "";
            wall = DB.SelectSrting(s);
            return wall;
        }
    }
}
