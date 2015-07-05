using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public  class Relation
    {
        private String relation;
        private Database DB = new Database();
        public String getRelation(int relationno)
        {
            String s = "SELECT relation FROM relation WHERE relation_no =" + relationno + "";
            relation = DB.SelectSrting(s);
            return relation;
        }
    }
}
