using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackEnd
{
    public  class Khana
    {
        private Database DB = new Database();
        public bool Insert(
            int khanano,
            String cncid,
            String userid,
            int roofno,
            int wallno, 
            int floorno, 
            int watersourceno, 
            int evaluationno, 
            int houseprice,
            int landamount,
            int landprice, 
            int cow, 
            int goat, 
            int hen, 
            int fruittree, 
            int vegitableland,
            int monthcovered,
            int bed,
            int chair,
            int radio, 
            int tv, 
            int tubewell, 
            int milkycow, 
            int milkygoat,
            int daylabourer,
            int labourdays,
            int latrine,
            String enumerator, 
            String cnoname, 
            String entrydate,
            String khanaid)
        {
            String s = "INSERT INTO khana ( khana_no,cnc_id,user_id,roof_no,wall_no,floor_no,water_source_no,evaluation_no,house_price,land_amount,land_price,cow,goat,hen,fruit_tree,vegitable_land,month_covered,bed,chair,radio,tv,tubewell,milky_cow,milky_goat,day_labourer,labour_days,latrine,enumerator,cno_name,entry_date, khana_id) VALUES (" 
                + khanano + ",'" + cncid + "','" + userid + "'," + roofno + "," + wallno + "," 
                + floorno + "," + watersourceno + "," + evaluationno + "," + houseprice + "," 
                + landamount + "," + landprice + "," + cow + "," + goat + "," + hen + "," 
                + fruittree + "," + vegitableland + "," + monthcovered + "," + bed + "," + chair + "," 
                + radio + "," + tv + "," + tubewell + "," + milkycow + "," + milkygoat + "," 
                + daylabourer + "," + labourdays + "," + latrine + ",'" + enumerator +
                "','" + cnoname + "','" + entrydate + "','" + khanaid + "')";
            //MessageBox.Show(s);
            bool inserted =DB.Insert(s);
            return inserted;
        }

        public String getUserId(String khanaid)
        {
            String s = "select user_id from khana where khana_id='"+khanaid+"'";
            String userid = DB.SelectSrting(s);
            return userid;
        }

        public String[] getAll(String khanaid)
        {
            int i=0;
            String[] ret= new String [30];
            String s = "SELECT  roof_no, wall_no, floor_no, house_price, land_amount, land_price, cow, goat, hen, fruit_tree, vegitable_land, month_covered, bed, chair, radio, tv, tubewell, milky_cow, milky_goat, day_labourer, labour_days, water_source_no, latrine, evaluation_no FROM khana where khana_id='" + khanaid + "'";
            String [,]a = DB.SelectColumns(s,"khana");
            while(i<30)
            {
                ret[i]=a[0,i];
                i++;
            }
            return ret;
        }
        public bool delete(String khanaid)
        {
            String s = "DELETE FROM khana WHERE khana_id = '" + khanaid + "'";
            bool deleted = DB.Insert(s);
            return deleted;

        }
    }
}
