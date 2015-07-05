using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class Roof
    {
        private String roof;
        private Database DB = new Database();
        public String getRoof(int roofno)
        {
            String s = "SELECT roof FROM roof WHERE roof_no ="+roofno+"";
            roof = DB.SelectSrting(s);
            return roof;
        }
    }
}
