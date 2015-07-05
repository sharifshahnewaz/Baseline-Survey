using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackEnd;
using System.Data;

namespace ReportsApplication1
{
    class reportgenerat
    {
        Database database = new Database();
        DataSet2 data_set;
        DataRow row;
        DataSet ds;
        DataTable dt;
        string query1, query2;
        string Thana_name = string.Empty;
        #region SET DATA

        public DataSet2 LoadData(string s)
        {
            data_set = new DataSet2();
            Thana_name = s;
            set_1();
            SET_1A();
            set_2();
            set_3();
            set_4();
            set_5();
            set_6();
            set_7();
            set_8();
            set_9();
            set_10();

            set_11();
            set_11A();
            set_11B();

            set_12();

            set_13();
            set_13A();
            set_13B();

            set_14();
            set_14B();
            set_14C();

            set_15();
            set_16();
            set_17();

            set_18();
            set_18A();
            set_18B();
            set_18C();
            set_18D();

            set_19();
            set_20();
            set_21();
            set_22();
            return data_set;

        }
      
     
        private void SET_1A()
        {
            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;
            query1 = "SELECT     a1.union_id, a1.union_no, a1.a AS cnc, a3.a AS household, a2.a AS member FROM         (SELECT     x.thana_name, [union].union_id, [union].union_no, isnull(x.a, 0) AS a                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     thana.thana_name, [union].union_id, [union].union_no, COUNT(cnc.cnc_id) AS a                                                    FROM          cnc INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                           thana ON [union].thana_id = thana.thana_id                                                    WHERE      (thana.thana_name = '" + Thana_name + "')                                                   GROUP BY thana.thana_name, [union].union_id, [union].union_no) x ON x.union_id = [union].union_id) a1 LEFT OUTER JOIN                          (SELECT     x.thana_name, [union].union_id, [union].union_no, isnull(x.a, 0) AS a                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     thana.thana_name, [union].union_id, [union].union_no, COUNT(member_id) AS a                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                thana ON [union].thana_id = thana.thana_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                 member ON khana.khana_id = member.khana_id                                                         WHERE      (thana.thana_name = '" + Thana_name + "')                                                         GROUP BY thana.thana_name, [union].union_id, [union].union_no) x ON x.union_id = [union].union_id) a2 ON                       a1.union_id = a2.union_id LEFT OUTER JOIN                          (SELECT     x.thana_name, [union].union_id, [union].union_no, isnull(x.a, 0) AS a                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     thana.thana_name, [union].union_id, [union].union_no, COUNT(khana_id) AS a                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                thana ON [union].thana_id = thana.thana_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id                                                         WHERE      (thana.thana_name = '" + Thana_name + "')                                                         GROUP BY thana.thana_name, [union].union_id, [union].union_no) x ON x.union_id = [union].union_id) a3 ON                       a2.union_id = a3.union_id";

            query2 = "SELECT     [union].union_name, [union].union_id FROM         thana INNER JOIN  [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "')";
            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table1A.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];

                        data_set.Table1A.Rows.Add(row);
                    }
                }
            }

        }

        private void set_1()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT  x.a AS union_id, x.b AS male, y.b AS female, ISNULL(x.b, 0) + ISNULL(y.b, 0) AS total FROM         (SELECT     [union].union_id AS a, isnull(x.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                    FROM          [union] INNER JOIN                                                                           cnc ON [union].union_id = cnc.union_id INNER JOIN                                                                           khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                           member ON khana.khana_id = member.khana_id                                                    WHERE      (member.sex_no = 1)                                                    GROUP BY [union].union_id) x ON x.union_id = [union].union_id) x LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, isnull(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          [union] INNER JOIN                                                                                cnc ON [union].union_id = cnc.union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      (member.sex_no = 2)                                                         GROUP BY [union].union_id) x ON x.union_id = [union].union_id) y ON x.a = y.a ORDER BY [union].union_id";
            query2 = "SELECT     [union].union_name, [union].union_id FROM         thana INNER JOIN  [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "')";
            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table1.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];

                        data_set.Table1.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_2()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     x.heading, x.male, y.female , male+female AS total FROM         (SELECT DISTINCT report2.heading, report2.id, ISNULL(x.a, 0) AS male                       FROM          report2 LEFT OUTER JOIN                                                  (SELECT     heading, id, COUNT(population) AS a                                                    FROM          (SELECT DISTINCT report2.heading, report2.id, rpt2.member_id AS population                                                                            FROM          report2 LEFT OUTER JOIN                                                                                                   rpt2 ON report2.id = rpt2.id                                                                            WHERE      (rpt2.sex_no = 1) AND (rpt2.thana_name = '" + Thana_name + "')) DERIVEDTBL                                                    GROUP BY heading, id) x ON x.heading = report2.heading) x LEFT OUTER JOIN                          (SELECT DISTINCT report2.heading, report2.id, ISNULL(x.a, 0) AS female                            FROM          report2 LEFT OUTER JOIN                                                       (SELECT     heading, id, COUNT(population) AS a                                                         FROM          (SELECT DISTINCT report2.heading, report2.id, rpt2.member_id AS population                                                                                 FROM          report2 LEFT OUTER JOIN                                                                                                        rpt2 ON report2.id = rpt2.id                                                                                 WHERE      (rpt2.sex_no = 2) AND (rpt2.thana_name = '" + Thana_name + "')) DERIVEDTBL                                                         GROUP BY heading, id) x ON x.heading = report2.heading) y ON x.heading = y.heading ORDER BY x.id SELECT distinct    x.heading, x.male, y.female, ISNULL(x.male, 0) + ISNULL(y.female, 0) AS both FROM         (SELECT     report2.heading, report2.id, ISNULL(a.population, 0) AS male                       FROM          report2 LEFT OUTER JOIN                                                  (SELECT     report2.heading, report2.id, COUNT(rpt2.member_id) AS population                                                    FROM          report2 LEFT OUTER JOIN                                                                           rpt2 ON report2.id = rpt2.id                                                    WHERE      (rpt2.sex_no = 1) AND thana_name = '" + Thana_name + "'                                                   GROUP BY report2.heading, report2.id) a ON report2.id = a.id) x LEFT OUTER JOIN                          (SELECT     report2.heading, report2.id, ISNULL(a.population, 0) AS female                            FROM          report2 LEFT OUTER JOIN                                                       (SELECT     report2.heading, report2.id, COUNT(rpt2.member_id) AS population                                                         FROM          report2 LEFT OUTER JOIN                                                                                rpt2 ON report2.id = rpt2.id                                                         WHERE      (rpt2.sex_no = 2) AND thana_name = '" + Thana_name + "'                                                         GROUP BY report2.heading, report2.id) a ON report2.id = a.id) y ON x.id = y.id";
            //query2 = "SELECT     [union].union_name, [union].union_id FROM         thana INNER JOIN  [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "')";
            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];

                row = data_set.Table2.NewRow();

                row[0] = r[0];
                row[1] = r[1];
                row[2] = r[2];
                row[3] = r[3];

                data_set.Table2.Rows.Add(row);


            }

            //throw new NotImplementedException();
        }
      
        private void set_3()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.a AS union_id, a.c AS self, b.c AS wife, c.c AS husband, d.c AS son, e.c AS daughter, f.c AS fathermother, g.c AS others, ISNULL(a.c, 0)                       + ISNULL(b.c, 0) + ISNULL(c.c, 0) + ISNULL(d.c, 0) + ISNULL(e.c, 0) + ISNULL(f.c, 0) + ISNULL(g.c, 0) AS total FROM         (SELECT     [union].union_id AS a, isnull(x.b, 0) AS c                        FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                    FROM          member INNER JOIN                                                                           relation ON member.relation_no = relation.relation_no INNER JOIN                                                                           khana ON member.khana_id = khana.khana_id INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (member.relation_no = 1)                                                    GROUP BY [union].union_id) x ON x.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 2)                                                         GROUP BY [union].union_id) x ON x.union_id = [union].union_id) b ON a.a = b.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 3)                                                         GROUP BY [union].union_id) x ON x.union_id = [union].union_id) c ON b.a = c.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 4)                                                         GROUP BY [union].union_id) x ON x.union_id = [union].union_id) d ON c.a = d.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 5)                                                         GROUP BY [union].union_id) x ON x.union_id = [union].union_id) e ON d.a = e.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 6)                                                         GROUP BY [union].union_id) x ON x.union_id = [union].union_id) f ON e.a = f.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 7)                                                         GROUP BY [union].union_id) x ON x.union_id = [union].union_id) g ON f.a = g.a ORDER BY [union].union_id";
            query2 = "SELECT     [union].union_name, [union].union_id FROM         thana INNER JOIN  [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "')";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table_3.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];
                        row[7] = r[7];
                        row[8] = r[8];
                        data_set.Table_3.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_4()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            // query1 = "SELECT     a.education AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM   (SELECT     education, SUM(p) AS b                       FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p  FROM      education LEFT OUTER JOIN   (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                             FROM          member INNER JOIN            education ON member.education_no = education.education_no INNER JOIN           khana ON member.khana_id = khana.khana_id INNER JOIN     cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id INNER JOIN       thana ON [union].thana_id = thana.thana_id   WHERE      (member.sex_no = 1) AND (member.relation_no = 1) AND thana_name = '"+Thana_name"+'     GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)                                               DERIVEDTBL                       GROUP BY education) a LEFT OUTER JOIN                          (SELECT     education, SUM(p) AS b                            FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p                                                    FROM          education LEFT OUTER JOIN                                                                               (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                                           FROM          member INNER JOIN           education ON member.education_no = education.education_no INNER JOIN        khana ON member.khana_id = khana.khana_id INNER JOIN       cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id INNER JOIN   thana ON [union].thana_id = thana.thana_id   WHERE (member.sex_no = 2) AND (member.relation_no = 1) AND thana_name = '"+comboBox_Thana.ToString()+"'       GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)     DERIVEDTBL      GROUP BY education) b ON a.education = b.education";
            query1 = "SELECT     x.a AS status, x.b AS male, y.b AS female, ISNULL(x.b, 0) + ISNULL(y.b, 0) AS total FROM         (SELECT     marital_status.status AS a, ISNULL(a.b, 0) AS b                       FROM          marital_status LEFT OUTER JOIN                                                  (SELECT     marital_status.status, COUNT(member.member_id) AS b                                                    FROM          [union] INNER JOIN                                                                           cnc ON [union].union_id = cnc.union_id INNER JOIN                                                                           khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                           member INNER JOIN                                                                           marital_status ON member.marital_no = marital_status.marital_no ON khana.khana_id = member.khana_id INNER JOIN                                                                           thana ON [union].thana_id = thana.thana_id                                                    WHERE      (member.sex_no = 1) AND (thana.thana_name = '" + Thana_name + "')                                                    GROUP BY marital_status.status) a ON a.status = marital_status.status) x INNER JOIN                          (SELECT     marital_status.status AS a, ISNULL(a.b, 0) AS b                            FROM          marital_status LEFT OUTER JOIN                                                       (SELECT     marital_status.status, COUNT(member.member_id) AS b                                                         FROM          [union] INNER JOIN                                                                                cnc ON [union].union_id = cnc.union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member INNER JOIN                                                                                marital_status ON member.marital_no = marital_status.marital_no ON khana.khana_id = member.khana_id INNER JOIN                         thana ON [union].thana_id = thana.thana_id                                                         WHERE      (member.sex_no = 2) AND (thana.thana_name = '" + Thana_name + "') GROUP BY marital_status.status) a ON a.status = marital_status.status) y ON x.a = y.a";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            // dt = database.return_dataset(query2);
            // ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {

                row = data_set.Table4.NewRow();

                row[0] = r[0];
                row[1] = r[1];
                row[2] = r[2];
                row[3] = r[3];
                data_set.Table4.Rows.Add(row);


            }

            //throw new NotImplementedException();
        }
        private void set_5()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            // query1 = "SELECT     a.education AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM   (SELECT     education, SUM(p) AS b                       FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p  FROM      education LEFT OUTER JOIN   (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                             FROM          member INNER JOIN            education ON member.education_no = education.education_no INNER JOIN           khana ON member.khana_id = khana.khana_id INNER JOIN     cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id INNER JOIN       thana ON [union].thana_id = thana.thana_id   WHERE      (member.sex_no = 1) AND (member.relation_no = 1) AND thana_name = '"+Thana_name"+'     GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)                                               DERIVEDTBL                       GROUP BY education) a LEFT OUTER JOIN                          (SELECT     education, SUM(p) AS b                            FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p                                                    FROM          education LEFT OUTER JOIN                                                                               (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                                           FROM          member INNER JOIN           education ON member.education_no = education.education_no INNER JOIN        khana ON member.khana_id = khana.khana_id INNER JOIN       cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id INNER JOIN   thana ON [union].thana_id = thana.thana_id   WHERE (member.sex_no = 2) AND (member.relation_no = 1) AND thana_name = '"+comboBox_Thana.ToString()+"'       GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)     DERIVEDTBL      GROUP BY education) b ON a.education = b.education";
            query1 = "SELECT     x.heading, x.male, y.female, x.male + y.female AS total FROM         (SELECT DISTINCT report5.heading, report5.id, ISNULL(x.a, 0) AS male                        FROM          report5 LEFT OUTER JOIN                                                  (SELECT     heading, id, COUNT(population) AS a                                                    FROM          (SELECT DISTINCT report5.heading, report5.id, rpt5.member_id AS population                                                                            FROM          report5 LEFT OUTER JOIN                                                                                                   rpt5 ON report5.id = rpt5.id                                                                            WHERE      (rpt5.sex_no = 1) AND (rpt5.thana_name = '"+Thana_name+"') AND marital_no = 1) DERIVEDTBL                                                    GROUP BY heading, id) x ON x.heading = report5.heading) x LEFT OUTER JOIN                          (SELECT DISTINCT report5.heading, report5.id, ISNULL(x.a, 0) AS female                            FROM          report5 LEFT OUTER JOIN                                                       (SELECT     heading, id, COUNT(population) AS a                                                         FROM          (SELECT DISTINCT report5.heading, report5.id, rpt5.member_id AS population                                                                                 FROM          report5 LEFT OUTER JOIN                                                                                                        rpt5 ON report5.id = rpt5.id                                                                                 WHERE      (rpt5.sex_no = 2) AND (rpt5.thana_name = '"+Thana_name+"') AND marital_no = 1) DERIVEDTBL                                                         GROUP BY heading, id) x ON x.heading = report5.heading) y ON x.heading = y.heading ORDER BY x.id";


            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            // dt = database.return_dataset(query2);
            // ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {

                row = data_set.Table5.NewRow();

                row[0] = r[0];
                row[1] = r[1];
                row[2] = r[2];
                row[3] = r[3];
                data_set.Table5.Rows.Add(row);


            }

            //throw new NotImplementedException();
        }
        private void set_6()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            // query1 = "SELECT     a.education AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM   (SELECT     education, SUM(p) AS b                       FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p  FROM      education LEFT OUTER JOIN   (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                             FROM          member INNER JOIN            education ON member.education_no = education.education_no INNER JOIN           khana ON member.khana_id = khana.khana_id INNER JOIN     cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id INNER JOIN       thana ON [union].thana_id = thana.thana_id   WHERE      (member.sex_no = 1) AND (member.relation_no = 1) AND thana_name = '"+Thana_name"+'     GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)                                               DERIVEDTBL                       GROUP BY education) a LEFT OUTER JOIN                          (SELECT     education, SUM(p) AS b                            FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p                                                    FROM          education LEFT OUTER JOIN                                                                               (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                                           FROM          member INNER JOIN           education ON member.education_no = education.education_no INNER JOIN        khana ON member.khana_id = khana.khana_id INNER JOIN       cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id INNER JOIN   thana ON [union].thana_id = thana.thana_id   WHERE (member.sex_no = 2) AND (member.relation_no = 1) AND thana_name = '"+comboBox_Thana.ToString()+"'       GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)     DERIVEDTBL      GROUP BY education) b ON a.education = b.education";
            query1 = "SELECT     a.education AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM         (SELECT     education, SUM(p) AS b                       FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p                                               FROM          education LEFT OUTER JOIN                                                                          (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                                                                            FROM          member INNER JOIN                                                                                                   education ON member.education_no = education.education_no INNER JOIN                                                                                                   khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                   cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   thana ON [union].thana_id = thana.thana_id                                                                            WHERE      (member.sex_no = 1) AND (member.age >6) AND thana_name = '" + Thana_name + "'                                                                          GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)                                               DERIVEDTBL                       GROUP BY education) a LEFT OUTER JOIN                          (SELECT     education, SUM(p) AS b                            FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p                                                    FROM          education LEFT OUTER JOIN                                                                               (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                                                                                FROM          member INNER JOIN                                                                                                        education ON member.education_no = education.education_no INNER JOIN                                                                                                        khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        thana ON [union].thana_id = thana.thana_id                                                                                 WHERE      (member.sex_no = 2) AND (member.age >6) AND thana_name = '" + Thana_name + "'                                                                                 GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)                                                   DERIVEDTBL                            GROUP BY education) b ON a.education = b.education";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            // dt = database.return_dataset(query2);
            // ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {

                row = data_set.Table6.NewRow();

                row[0] = r[0];
                row[1] = r[1];
                row[2] = r[2];
                row[3] = r[3];
                data_set.Table6.Rows.Add(row);


            }

            //throw new NotImplementedException();
        }
        private void set_7()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            // query1 = "SELECT     a.education AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM   (SELECT     education, SUM(p) AS b                       FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p  FROM      education LEFT OUTER JOIN   (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                             FROM          member INNER JOIN            education ON member.education_no = education.education_no INNER JOIN           khana ON member.khana_id = khana.khana_id INNER JOIN     cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id INNER JOIN       thana ON [union].thana_id = thana.thana_id   WHERE      (member.sex_no = 1) AND (member.relation_no = 1) AND thana_name = '"+Thana_name"+'     GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)                                               DERIVEDTBL                       GROUP BY education) a LEFT OUTER JOIN                          (SELECT     education, SUM(p) AS b                            FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p                                                    FROM          education LEFT OUTER JOIN                                                                               (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                                           FROM          member INNER JOIN           education ON member.education_no = education.education_no INNER JOIN        khana ON member.khana_id = khana.khana_id INNER JOIN       cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id INNER JOIN   thana ON [union].thana_id = thana.thana_id   WHERE (member.sex_no = 2) AND (member.relation_no = 1) AND thana_name = '"+comboBox_Thana.ToString()+"'       GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)     DERIVEDTBL      GROUP BY education) b ON a.education = b.education";
            query1 = "SELECT     a.education AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM         (SELECT     education, SUM(p) AS b                        FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p                                               FROM          education LEFT OUTER JOIN                                                                          (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                                                                         FROM          member INNER JOIN                                                                                                   education ON member.education_no = education.education_no INNER JOIN                                                                                                   khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                              cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                  [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   thana ON [union].thana_id = thana.thana_id                                                                            WHERE      (member.sex_no = 1) AND (member.relation_no = 1) AND thana_name = '" + Thana_name + "'                                                                           GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)                                               DERIVEDTBL                       GROUP BY education) a LEFT OUTER JOIN                          (SELECT     education, SUM(p) AS b                            FROM          (SELECT     education.education, ISNULL(a.b, 0) AS p                                                    FROM          education LEFT OUTER JOIN                                                                               (SELECT     education.education, education.education_no, COUNT(member.member_id) AS b                                                                                 FROM          member INNER JOIN                                                                                                        education ON member.education_no = education.education_no INNER JOIN                                                                                                        khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                       cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        thana ON [union].thana_id = thana.thana_id                                                                                 WHERE      (member.sex_no = 2) AND (member.relation_no = 1) AND thana_name = '" + Thana_name + "'                                                                                GROUP BY education.education, education.education_no) a ON a.education_no = education.education_no)                                                    DERIVEDTBL                            GROUP BY education) b ON a.education = b.education";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            // dt = database.return_dataset(query2);
            // ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {

                row = data_set.Table7.NewRow();

                row[0] = r[0];
                row[1] = r[1];
                row[2] = r[2];
                row[3] = r[3];
                data_set.Table7.Rows.Add(row);


            }

            //throw new NotImplementedException();
        }
        private void set_8()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.occupation AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM         (SELECT     occupation, occupation_no, SUM(p) AS b                       FROM          (SELECT     occupation.occupation, occupation.occupation_no, ISNULL(a.b, 0) AS p                                               FROM          occupation LEFT OUTER JOIN                                                                          (SELECT     occupation.occupation, occupation.occupation_no, COUNT(member.member_id) AS b                                                                            FROM          member INNER JOIN                                                                                                   occupation ON member.occupation_no = occupation.occupation_no INNER JOIN                                                                                                   khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                   cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   thana ON [union].thana_id = thana.thana_id                                                                            WHERE      (member.sex_no = 1) AND (member.age > 10) AND thana_name = '"+Thana_name+"'                                                                            GROUP BY occupation.occupation, occupation.occupation_no) a ON a.occupation_no = occupation.occupation_no)                                               DERIVEDTBL                       GROUP BY occupation, occupation_no) a LEFT OUTER JOIN                          (SELECT     occupation, occupation_no, SUM(p) AS b                            FROM          (SELECT     occupation.occupation, occupation.occupation_no, ISNULL(a.b, 0) AS p                                                    FROM          occupation LEFT OUTER JOIN                                                                               (SELECT     occupation.occupation, occupation.occupation_no, COUNT(member.member_id) AS b                                                                                 FROM          member INNER JOIN                                                                                                        occupation ON member.occupation_no = occupation.occupation_no INNER JOIN                                                                                                        khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        thana ON [union].thana_id = thana.thana_id                                                                                 WHERE      (member.sex_no = 2) AND (member.age > 10) AND thana_name = '"+Thana_name+"'                                                                                 GROUP BY occupation.occupation, occupation.occupation_no) a ON a.occupation_no = occupation.occupation_no)                                                    DERIVEDTBL                            GROUP BY occupation, occupation_no) b ON a.occupation = b.occupation";
            //query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            // dt = database.return_dataset(query2);
            // ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                row = data_set.Table8.NewRow();
                row[0] = r[1];
                row[1] = r[2];
                row[2] = r[0];
                row[3] = r[3];
                data_set.Table8.Rows.Add(row);

            }

            //throw new NotImplementedException();
        }
        private void set_9()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.occupation AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM         (SELECT     occupation, occupation_no, SUM(p) AS b                       FROM          (SELECT     occupation.occupation, occupation.occupation_no, ISNULL(a.b, 0) AS p                                               FROM          occupation LEFT OUTER JOIN                                                                          (SELECT     occupation.occupation, occupation.occupation_no, COUNT(member.member_id) AS b                                                                            FROM          member INNER JOIN                                                                                                   occupation ON member.occupation_no = occupation.occupation_no INNER JOIN                                                                                                   khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                   cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   thana ON [union].thana_id = thana.thana_id                                                                            WHERE      (member.sex_no = 1) AND (member.relation_no = 1) AND thana_name = '"+Thana_name+"'                                                                            GROUP BY occupation.occupation, occupation.occupation_no) a ON a.occupation_no = occupation.occupation_no)                                               DERIVEDTBL                       GROUP BY occupation, occupation_no) a LEFT OUTER JOIN                          (SELECT     occupation, occupation_no, SUM(p) AS b                            FROM          (SELECT     occupation.occupation, occupation.occupation_no, ISNULL(a.b, 0) AS p                                                    FROM          occupation LEFT OUTER JOIN                                                                               (SELECT     occupation.occupation, occupation.occupation_no, COUNT(member.member_id) AS b                                                                                 FROM          member INNER JOIN                                                                                                        occupation ON member.occupation_no = occupation.occupation_no INNER JOIN                                                                                                        khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        thana ON [union].thana_id = thana.thana_id                                                                                 WHERE      (member.sex_no = 2) AND (member.relation_no = 1) AND thana_name = '"+Thana_name+"'                                                                                 GROUP BY occupation.occupation, occupation.occupation_no) a ON a.occupation_no = occupation.occupation_no)                                                    DERIVEDTBL                            GROUP BY occupation, occupation_no) b ON a.occupation = b.occupation";
            //query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);

            foreach (DataRow r in ds.Tables[0].Rows)
            {


                row = data_set.Table9.NewRow();

                row[0] = r[1];
                row[1] = r[2];
                row[2] = r[0];
                row[3] = r[3];
                data_set.Table9.Rows.Add(row);


            }

            //throw new NotImplementedException();
        }
        private void set_10()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a1.unionname, a1.khana AS [<5], a2.khana AS [5-6], a3.khana AS [7-8], a4.khana AS [9-10], a5.khana AS [11+], ISNULL(a1.khana, 0) + ISNULL(a2.khana,                       0) + ISNULL(a3.khana, 0) + ISNULL(a4.khana, 0) + ISNULL(a5.khana, 0) AS total FROM         (SELECT     [union].union_id AS unionname, ISNULL(p.khana, 0) AS khana                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     union_id, isnull(COUNT(b), 0) AS khana                                                    FROM          (SELECT     [union].union_id, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                            FROM          khana INNER JOIN                                                                                                   cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id LEFT JOIN                                                                                                   member ON khana.khana_id = member.khana_id                                                                            GROUP BY [union].union_id, khana.khana_id                                                                            HAVING      (COUNT(member.member_id) < 5)) DERIVEDTBL                                                    GROUP BY union_id) p ON p.union_id = [union].union_id) a1 LEFT OUTER JOIN                          (SELECT     [union].union_id AS unionname, ISNULL(p.khana, 0) AS khana                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_id, isnull(COUNT(b), 0) AS khana                                                         FROM          (SELECT     [union].union_id, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          khana INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id LEFT JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 GROUP BY [union].union_id, khana.khana_id                                                                                 HAVING      (COUNT(member.member_id) BETWEEN 5 AND 6)) DERIVEDTBL                                                         GROUP BY union_id) p ON p.union_id = [union].union_id) a2 ON a1.unionname = a2.unionname LEFT OUTER JOIN                          (SELECT     [union].union_id AS unionname, ISNULL(p.khana, 0) AS khana                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_id, isnull(COUNT(b), 0) AS khana                                                         FROM          (SELECT     [union].union_id, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          khana INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id LEFT JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 GROUP BY [union].union_id, khana.khana_id                                                                                 HAVING      (COUNT(member.member_id) BETWEEN 7 AND 8)) DERIVEDTBL                                                         GROUP BY union_id) p ON p.union_id = [union].union_id) a3 ON a2.unionname = a3.unionname LEFT OUTER JOIN                          (SELECT     [union].union_id AS unionname, ISNULL(p.khana, 0) AS khana                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_id, isnull(COUNT(b), 0) AS khana                                                         FROM          (SELECT     [union].union_id, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          khana INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id LEFT JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 GROUP BY [union].union_id, khana.khana_id                                                                                 HAVING      (COUNT(member.member_id) BETWEEN 9 AND 10)) DERIVEDTBL                                                         GROUP BY union_id) p ON p.union_id = [union].union_id) a4 ON a3.unionname = a4.unionname LEFT OUTER JOIN                          (SELECT     [union].union_id AS unionname, ISNULL(p.khana, 0) AS khana                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_id, isnull(COUNT(b), 0) AS khana                                                         FROM          (SELECT     [union].union_id, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          khana INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id LEFT JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 GROUP BY [union].union_id, khana.khana_id                                                                                 HAVING      (COUNT(member.member_id) >= 11)) DERIVEDTBL                                                         GROUP BY union_id) p ON p.union_id = [union].union_id) a5 ON a4.unionname = a5.unionname ORDER BY a1.unionname";
            query2 = "SELECT     [union].union_name, [union].union_id FROM         thana INNER JOIN  [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "')";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table10.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];

                        data_set.Table10.Rows.Add(row);
                    }
                }
                int i = 10;
            }

            //throw new NotImplementedException();
        }
        private void set_11()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a1.a AS unionname, a1.b AS pacca, a2.b AS tin, a3.b AS [straw/bamboo], a4.b AS earth, a5.b AS others, ISNULL(a1.b, 0) + ISNULL(a2.b, 0)                       + ISNULL(a3.b, 0) + ISNULL(a4.b, 0) + ISNULL(a5.b, 0) AS total FROM         (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     a AS union_id, COUNT(c) AS b                                                    FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                            FROM          cnc INNER JOIN                                                                                                   khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                   roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   member ON khana.khana_id = khana.khana_id                                                                            WHERE      (khana.roof_no = 1)                                                                            GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                    GROUP BY a) x ON [union].union_id = x.union_id) a1 LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.roof_no = 2)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a2 ON a1.a = a2.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.roof_no = 3)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a3 ON a2.a = a3.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.roof_no = 4)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a4 ON a3.a = a4.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.roof_no = 5)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a5 ON a4.a = a5.a";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table11.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];

                        data_set.Table11.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_11A()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a1.a AS unionname, a1.b AS pacca, a2.b AS tin, a3.b AS [straw/bamboo], a4.b AS earth, a5.b AS others, ISNULL(a1.b, 0) + ISNULL(a2.b, 0)                       + ISNULL(a3.b, 0) + ISNULL(a4.b, 0) + ISNULL(a5.b, 0) AS total FROM         (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     a AS union_id, COUNT(c) AS b                                                    FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                            FROM          cnc INNER JOIN                                                                                                   khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                   wall ON khana.wall_no = wall.wall_no INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   member ON khana.khana_id = khana.khana_id                                                                            WHERE      (khana.wall_no = 1)                                                                            GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                    GROUP BY a) x ON [union].union_id = x.union_id) a1 LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        wall ON khana.wall_no = wall.wall_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.wall_no = 2)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a2 ON a1.a = a2.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        wall ON khana.wall_no = wall.wall_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.wall_no = 3)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a3 ON a2.a = a3.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        wall ON khana.wall_no = wall.wall_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.wall_no = 4)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a4 ON a3.a = a4.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        wall ON khana.wall_no = wall.wall_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.wall_no = 5)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a5 ON a4.a = a5.a";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table11A.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];

                        data_set.Table11A.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_11B()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = " SELECT     a1.a AS unionname, a1.b AS pacca, a2.b AS tin, a3.b AS [straw/bamboo], a4.b AS earth, a5.b AS others, ISNULL(a1.b, 0) + ISNULL(a2.b, 0)                       + ISNULL(a3.b, 0) + ISNULL(a4.b, 0) + ISNULL(a5.b, 0) AS total FROM         (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     a AS union_id, COUNT(c) AS b                                                    FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                            FROM          cnc INNER JOIN                                                                                                   khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                   floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   member ON khana.khana_id = khana.khana_id                                                                            WHERE      (khana.floor_no = 1)                                                                            GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                    GROUP BY a) x ON [union].union_id = x.union_id) a1 LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.floor_no = 2)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a2 ON a1.a = a2.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.floor_no = 3)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a3 ON a2.a = a3.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.floor_no = 4)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a4 ON a3.a = a4.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.floor_no = 5)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a5 ON a4.a = a5.a";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table11B.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];

                        data_set.Table11B.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_12()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [<5000], b.y AS [5000-9999], c.y AS [10000-14999], d.y AS [15000-19999], e.y AS [20000-24999], f.y AS [25000-49999],                       g.y AS [50000+], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) + ISNULL(e.y, 0) + ISNULL(f.y, 0) + ISNULL(g.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.house_price < 5000)                                                    GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.house_price BETWEEN 5000 AND 9999)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.house_price BETWEEN 10000 AND 14999)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) g RIGHT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.house_price BETWEEN 15000 AND 19999)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) f ON g.x = f.x RIGHT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.house_price BETWEEN 20000 AND 24999)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) e ON f.x = e.x RIGHT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.house_price BETWEEN 25000 AND 49000)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) d ON e.x = d.x RIGHT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.house_price >= 50000)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) c ON d.x = c.x ON b.x = c.x";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table12.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];
                        row[7] = r[7];
                        row[8] = r[8];
                        //row[9] = r[9];

                        data_set.Table12.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_13()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [no land], b.y AS [<.05], c.y AS [0.05 - 0.24], d.y AS [0.25 - 0.49], e.y AS [0.50 - 0.99], f.y AS [1.0 - 1.49], g.y AS [1.5-1.99],                       h.y AS [2+], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) + ISNULL(e.y, 0) + ISNULL(f.y, 0) + ISNULL(g.y, 0) + ISNULL(h.y, 0)                       AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.land_amount = 0)                                                    GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount >0 and  khana.land_amount < 5)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 5 AND 24)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 25 AND 49)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 50 AND 99)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) e ON d.x = e.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 100 AND 149)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) f ON e.x = f.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 150 AND 199)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) g ON f.x = g.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount >= 200)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) h ON g.x = h.x";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table13.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];
                        row[7] = r[7];
                        row[8] = r[8];
                        row[9] = r[9];

                        data_set.Table13.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_13A()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [<5000], b.y AS [5000-9999], c.y AS [10000-14999], d.y AS [15000-19999], e.y AS [20000-24999], f.y AS [25000-49999],           g.y AS [50000+], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) + ISNULL(e.y, 0) + ISNULL(f.y, 0) + ISNULL(g.y, 0) AS total FROM         (SELECT     [union].union_id x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT    cnc.union_id, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.land_price < 5000)                                                    GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT    cnc.union_id, COUNT(khana_id) AS y                                                        FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 5000 AND 9999)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT    cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 10000 AND 14999)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id x, ISNULL(a.y, 0) AS y                           FROM          [union] LEFT OUTER JOIN                                                       (SELECT    cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 15000 AND 19999)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x LEFT OUTER JOIN                         (SELECT     [union].union_id x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT    cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 20000 AND 24999)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) e ON d.x = e.x LEFT OUTER JOIN                          (SELECT     [union].union_id x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT    cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 25000 AND 49999)                                                        GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) f ON e.x = f.x LEFT OUTER JOIN                          (SELECT     [union].union_id x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT    cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price >= 50000)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) g ON f.x = g.x";

            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table13A.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];
                        row[7] = r[7];
                        row[8] = r[8];
                        //row[9] = r[9];

                        data_set.Table13A.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_13B()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS no, b.y AS [<5], c.y AS [5 - 10], d.y AS [11 - 15], e.y AS [16 - 20], f.y AS [20+], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0)                       + ISNULL(d.y, 0) + ISNULL(e.y, 0) + ISNULL(f.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.vegitable_land = 0)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land > 0 and khana.vegitable_land < 5)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                          FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land BETWEEN 5 AND 10)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land BETWEEN 11 AND 15)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land BETWEEN 16 AND 20)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) e ON d.x = e.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land > 20)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) f ON e.x = f.x ORDER BY [union name]";


            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table13B.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];
                        row[7] = r[7];
                        // row[8] = r[8];
                        //row[9] = r[9];

                        data_set.Table13B.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_14()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [1-2], b.y AS [3 - 4], c.y AS [4+], d.y AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.cow BETWEEN 1 AND 2)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.cow BETWEEN 3 AND 4)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.cow > 4)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.cow = 0)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x ORDER BY [union name]";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table14Cow.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[2];
                        row[2] = r[3];
                        row[3] = r[1];
                        row[4] = r[4];
                        row[5] = r[5];
                        data_set.Table14Cow.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_14B()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [1-2], b.y AS [3 - 4], c.y AS [4+], d.y AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.goat BETWEEN 1 AND 2)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.goat BETWEEN 3 AND 4)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.goat > 4)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.goat = 0)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x";

            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table14Goat.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];


                        data_set.Table14Goat.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_14C()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [1-2], b.y AS [3 - 4], c.y AS [4+], d.y AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.hen BETWEEN 1 AND 2)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.hen BETWEEN 3 AND 4)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.hen > 4)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.hen = 0)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table14Hen.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];


                        data_set.Table14Hen.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_15()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [1-2], b.y AS [3 - 4], c.y AS [4+], d.y AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.fruit_tree BETWEEN 1 AND 2)                                                    GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.fruit_tree BETWEEN 3 AND 4)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.fruit_tree > 4)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.fruit_tree = 0)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x";
            query2 = "SELECT  [union].union_name,union_id FROM  thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table15.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];

                        data_set.Table15.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_16()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [0 - 3], b.y AS [4 - 6], c.y AS [7 - 9], d.y AS [10 - 11], e.y AS [12], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0)    + ISNULL(d.y, 0) + ISNULL(e.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.month_covered <= 3)                                                    GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.month_covered BETWEEN 4 AND 6)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.month_covered BETWEEN 7 AND 9)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.month_covered BETWEEN 10 AND 11)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x LEFT OUTER JOIN    (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y    FROM          [union] LEFT OUTER JOIN  (SELECT     cnc.union_id, COUNT(khana_id) AS y  FROM          khana INNER JOIN  cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id  WHERE (khana.month_covered >= 12)   GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) e ON d.x = e.x";

            query2 = "SELECT  [union].union_name,union_id FROM  thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table16.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];
                        data_set.Table16.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_17()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], a.y AS [0 - 120], b.y AS [121 - 180], c.y AS [181 - 240], d.y AS [241 - 300], e.y AS [300+], ISNULL(a.y, 0) + ISNULL(b.y, 0)                       + ISNULL(c.y, 0) + ISNULL(d.y, 0) + ISNULL(e.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.labour_days <= 120)                                                    GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.labour_days BETWEEN 121 AND 180)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.labour_days BETWEEN 181 AND 240)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.labour_days BETWEEN 241 AND 300)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) d ON c.x = d.x LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     cnc.union_id, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.labour_days > 300)                                                         GROUP BY cnc.union_id) a ON a.union_id = [union].union_id) e ON d.x = e.x";
            query2 = "SELECT  [union].union_name,union_id FROM  thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table17.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];
                        data_set.Table17.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_18()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                        FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.bed = 1)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.bed <> 1)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x ORDER BY [union name]";

            query2 = "SELECT  [union].union_name,union_id   FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table18.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];


                        data_set.Table18.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_18A()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                        FROM          [union] LEFT OUTER JOIN                                               (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.chair = 1)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.chair  <>1)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x";

            query2 = "SELECT  [union].union_name,union_id   FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table18A.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];


                        data_set.Table18A.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_18B()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                          [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.radio = 1)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.radio <>1)                                                       GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x";


            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table18B.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];


                        data_set.Table18B.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_18C()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = " SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.tv = 1)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.tv <>1)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x";


            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table18C.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];


                        data_set.Table18C.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_18D()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.tubewell = 1)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a LEFT OUTER JOIN                          (SELECT     [union].union_id AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.tubewell <>1)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) b ON a.x = b.x ORDER BY [union name]";


            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table18D.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];


                        data_set.Table18D.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_19()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a1.a AS unionname, a1.b AS tubewell, a2.b AS well, a3.b AS ponds, a4.b AS others, ISNULL(a1.b, 0) + ISNULL(a2.b, 0) + ISNULL(a3.b, 0) + ISNULL(a4.b,                       0) AS total FROM         (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                 (SELECT     a AS union_id, COUNT(c) AS b                                                    FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                            FROM          cnc INNER JOIN                                                                                                   khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                   water_source ON khana.water_source_no = water_source.water_source_no INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   member ON khana.khana_id = khana.khana_id                                                                            WHERE      (khana.water_source_no = 1)                                                                            GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                    GROUP BY a) x ON [union].union_id = x.union_id) a1 LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        water_source ON khana.water_source_no = water_source.water_source_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.water_source_no = 2)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a2 ON a1.a = a2.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        water_source ON khana.water_source_no = water_source.water_source_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.water_source_no = 3)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a3 ON a2.a = a3.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_id, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_id AS a, khana.khana_id AS b, COUNT(khana.khana_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        water_source ON khana.water_source_no = water_source.water_source_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = khana.khana_id                                                                                 WHERE      (khana.water_source_no = 4)                                                                                 GROUP BY [union].union_id, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_id = x.union_id) a4 ON a3.a = a4.a";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table19.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];


                        data_set.Table19.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }

        private void set_20()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     x.a AS unionname, x.b AS yes, y.b AS no, ISNULL(x.b, 0) + ISNULL(y.b, 0) AS total FROM         (SELECT     [union].union_id AS a, ISNULL(p.b, 0) AS b       FROM          [union] LEFT OUTER JOIN                                                   (SELECT     [union].union_id, COUNT(khana.khana_id) AS b                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.latrine = 1)                                                    GROUP BY [union].union_id) p ON [union].union_id = p.union_id) x LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(p.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(khana.khana_id) AS b                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.latrine <>1)                                                         GROUP BY [union].union_id) p ON [union].union_id = p.union_id) y ON x.a = y.a ORDER BY unionname";

            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table20.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];


                        data_set.Table20.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_21()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     x.a AS [union name], x.b AS [<3], y.b AS [3-4], z.b AS [4+], ISNULL(x.b, 0) + ISNULL(z.b, 0) + ISNULL(y.b, 0) AS total FROM         (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                    FROM          cnc INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                           khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                           member ON khana.khana_id = member.khana_id                                                    WHERE      (member.weight>0 and member.weight < 3 AND  age <= 2)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) x LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      (member.weight BETWEEN 3 AND 4 AND  age <= 2)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) y ON x.a = y.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      (member.weight > 4 AND  age <= 2)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) z ON y.a = z.a";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table21.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];


                        data_set.Table21.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_22()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a1.a AS [union name], a1.b AS [<16], a2.b AS [16-16.9], a3.b AS [17-17.9], ISNULL(a4.b, 0) AS [18-18.9], ISNULL(a5.b, 0) AS [19-19.9], ISNULL(a6.b, 0)                       AS [20+], ISNULL(a1.b, 0) + ISNULL(a3.b, 0) + ISNULL(a4.b, 0) + ISNULL(a5.b, 0) + ISNULL(a6.b, 0) AS total FROM         (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                    FROM          cnc INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                           khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                           member ON khana.khana_id = member.khana_id                                                    WHERE      ((weight * 10000 / (height * height + 1)) BETWEEN 10 AND 15.99999999 AND sex_no = 2 AND age BETWEEN 13 AND 44)                                                    GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a1 LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      ((weight * 10000 / (height * height + 1)) BETWEEN 16 AND 16.9999999 AND sex_no = 2 AND age BETWEEN 13 AND 44)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a2 ON a1.a = a2.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      ((weight * 10000 / (height * height + 1)) BETWEEN 17 AND 17.9999999 AND sex_no = 2 AND age BETWEEN 13 AND 44)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a3 ON a2.a = a3.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      ((weight * 10000 / (height * height + 1)) BETWEEN 18 AND 18.9999999 AND sex_no = 2 AND age BETWEEN 13 AND 44)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a4 ON a3.a = a4.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      ((weight * 10000 / (height * height + 1)) BETWEEN 19 AND 19.9999999 AND sex_no = 2 AND age BETWEEN 13 AND 44)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a5 ON a4.a = a5.a LEFT OUTER JOIN                          (SELECT     [union].union_id AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_id, COUNT(member.member_id) AS b                                                         FROM          cnc INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      ((weight * 10000 / (height * height + 1)) BETWEEN 20 AND 40 AND sex_no = 2 AND age BETWEEN 13 AND 44)                                                         GROUP BY [union].union_id) a ON a.union_id = [union].union_id) a6 ON a5.a = a6.a";
            query2 = "SELECT  [union].union_name,union_id FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

            dt = database.return_dataset(query1);
            ds.Tables.Add(dt);
            dt = database.return_dataset(query2);
            ds.Tables.Add(dt);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                DataColumn column = ds.Tables[0].Columns[0];
                foreach (DataRow r1 in ds.Tables[1].Rows)
                {

                    row = data_set.Table22.NewRow();
                    DataColumn column1 = ds.Tables[1].Columns[1];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r1[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[4] = r[4];
                        row[5] = r[5];
                        row[6] = r[6];
                        row[7] = r[7];


                        data_set.Table22.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }



        #endregion


    }
}
