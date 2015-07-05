using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class Evaluation
    {
        private String evaluation;
        private Database DB = new Database();
        public String getEvaluation(int evaluationno)
        {
            String s = "SELECT evaluation FROM evaluation WHERE evaluation_no =" + evaluationno + "";
            evaluation = DB.SelectSrting(s);
            return evaluation;
        }
    }
}
