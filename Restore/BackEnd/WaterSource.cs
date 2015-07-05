using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class WaterSource
    {
        private String watersource;
        private Database DB = new Database();
        public String getWaterSource(int watersourceno)
        {
            String s = "SELECT water_source FROM water_source WHERE water_source_no =" + watersourceno + "";
            watersource = DB.SelectSrting(s);
            return watersource;
        }
    }
}
