using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public  class Education
    {
        private String education;
        private Database DB = new Database();
        public String getEducation(int educationno)
        {
            String s = "SELECT education FROM education WHERE education_no =" + educationno + "";
            education = DB.SelectSrting(s);
            return education;
        }
    }
}
