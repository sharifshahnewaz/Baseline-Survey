using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using ReportsApplication1.DataSet2TableAdapters;
using BackEnd;


namespace ReportsApplication1
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        DataSet2 data_set;
        DataRow row;
        DataSet ds;
        DataTable dt;

        string Thana_name = string.Empty;
            
        string query1, query2;
        public Form1()
        {
            InitializeComponent();
            data_set = new DataSet2();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.Table1' table. You can move, or remove it, as needed.
            this.Table1TableAdapter.Fill(this.DataSet2.Table1);
            // TODO: This line of code loads data into the 'DataSet2.Table14Hen' table. You can move, or remove it, as needed.
            this.Table14HenTableAdapter.Fill(this.DataSet2.Table14Hen);
            // TODO: This line of code loads data into the 'DataSet2.Table14Goat' table. You can move, or remove it, as needed.
            this.Table14GoatTableAdapter.Fill(this.DataSet2.Table14Goat);
            // TODO: This line of code loads data into the 'DataSet2.Table14Cow' table. You can move, or remove it, as needed.
            this.Table14CowTableAdapter.Fill(this.DataSet2.Table14Cow);
            // TODO: This line of code loads data into the 'DataSet2.Table19' table. You can move, or remove it, as needed.
            this.Table19TableAdapter.Fill(this.DataSet2.Table19);
            // TODO: This line of code loads data into the 'DataSet2.Table4' table. You can move, or remove it, as needed.
            this.Table4TableAdapter.Fill(this.DataSet2.Table4);
            // TODO: This line of code loads data into the 'DataSet2.Table6' table. You can move, or remove it, as needed.
            this.Table6TableAdapter.Fill(this.DataSet2.Table6);
            // TODO: This line of code loads data into the 'DataSet2.Table7' table. You can move, or remove it, as needed.
            this.Table7TableAdapter.Fill(this.DataSet2.Table7);
            // TODO: This line of code loads data into the 'DataSet2.Table8' table. You can move, or remove it, as needed.
            this.Table8TableAdapter.Fill(this.DataSet2.Table8);
            // TODO: This line of code loads data into the 'DataSet2.Table9' table. You can move, or remove it, as needed.
            this.Table9TableAdapter.Fill(this.DataSet2.Table9);
            // TODO: This line of code loads data into the 'DataSet2.Table13B' table. You can move, or remove it, as needed.
            this.Table13BTableAdapter.Fill(this.DataSet2.Table13B);
            // TODO: This line of code loads data into the 'DataSet2.Table13A' table. You can move, or remove it, as needed.
            this.Table13ATableAdapter.Fill(this.DataSet2.Table13A);
            // TODO: This line of code loads data into the 'DataSet2.Table13' table. You can move, or remove it, as needed.
            this.Table13TableAdapter.Fill(this.DataSet2.Table13);
            // TODO: This line of code loads data into the 'DataSet2.Table18D' table. You can move, or remove it, as needed.
            this.Table18DTableAdapter.Fill(this.DataSet2.Table18D);
            // TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1);
            // TODO: This line of code loads data into the 'DataSet2.Table18C' table. You can move, or remove it, as needed.
            this.Table18CTableAdapter.Fill(this.DataSet2.Table18C);
            // TODO: This line of code loads data into the 'DataSet2.Table18B' table. You can move, or remove it, as needed.
            this.Table18BTableAdapter.Fill(this.DataSet2.Table18B);
            // TODO: This line of code loads data into the 'DataSet2.Table18A' table. You can move, or remove it, as needed.
            this.Table18ATableAdapter.Fill(this.DataSet2.Table18A);
            // TODO: This line of code loads data into the 'DataSet2.Table17' table. You can move, or remove it, as needed.
            this.Table17TableAdapter.Fill(this.DataSet2.Table17);
            // TODO: This line of code loads data into the 'DataSet2.Table18' table. You can move, or remove it, as needed.
            this.Table18TableAdapter.Fill(this.DataSet2.Table18);
            // TODO: This line of code loads data into the 'DataSet2.Table21' table. You can move, or remove it, as needed.
            this.Table21TableAdapter.Fill(this.DataSet2.Table21);
            // TODO: This line of code loads data into the 'DataSet2.Table15' table. You can move, or remove it, as needed.
            this.Table15TableAdapter.Fill(this.DataSet2.Table15);
            // TODO: This line of code loads data into the 'DataSet2.Table16' table. You can move, or remove it, as needed.
            this.Table16TableAdapter.Fill(this.DataSet2.Table16);
            // TODO: This line of code loads data into the 'DataSet2.Table20' table. You can move, or remove it, as needed.
            this.Table20TableAdapter.Fill(this.DataSet2.Table20);
            // TODO: This line of code loads data into the 'DataSet2.Table10' table. You can move, or remove it, as needed.
            this.Table10TableAdapter.Fill(this.DataSet2.Table10);
            // TODO: This line of code loads data into the 'DataSet2.Table_3' table. You can move, or remove it, as needed.
            this.Table_3TableAdapter.Fill(this.DataSet2.Table_3);
            // TODO: This line of code loads data into the 'DataSet2.Table12' table. You can move, or remove it, as needed.
            this.Table12TableAdapter.Fill(this.DataSet2.Table12);
            this.reportViewer1.RefreshReport();
        }
        #region SET DATA

        public void LoadData()
        {
            data_set = new DataSet2();
            Thana_name = comboBox_Thana.Text.ToString();
            set_1();
            set_3();
            set_4();
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

        }

        private void set_1()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT DISTINCT x.a AS union_name, x.b AS male, y.b AS female, ISNULL(x.b, 0) + ISNULL(y.b, 0) AS total FROM         (SELECT     [union].union_name AS a, isnull(x.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                    FROM          [union] INNER JOIN                                                                           cnc ON [union].union_id = cnc.union_id INNER JOIN                                                                           khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                           member ON khana.khana_id = member.khana_id                                                    WHERE      (member.sex_no = 1)                                                    GROUP BY [union].union_name) x ON x.union_name = [union].union_name) x LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, isnull(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                         FROM          [union] INNER JOIN                                                                                cnc ON [union].union_id = cnc.union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member ON khana.khana_id = member.khana_id                                                         WHERE      (member.sex_no = 2)                                                         GROUP BY [union].union_name) x ON x.union_name = [union].union_name) y ON x.a = y.a";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];

                        data_set.Table1.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_3()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT DISTINCT                       a.a AS union_name, a.c AS self, b.c AS wife, c.c AS husband, d.c AS son, e.c AS daughter, f.c AS fathermother, g.c AS others, ISNULL(a.c, 0)                       + ISNULL(b.c, 0) + ISNULL(c.c, 0) + ISNULL(d.c, 0) + ISNULL(e.c, 0) + ISNULL(f.c, 0) + ISNULL(g.c, 0) AS total FROM         (SELECT     [union].union_name AS a, isnull(x.b, 0) AS c                        FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                    FROM          member INNER JOIN                                                                           relation ON member.relation_no = relation.relation_no INNER JOIN                                                                           khana ON member.khana_id = khana.khana_id INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (member.relation_no = 1)                                                    GROUP BY [union].union_name) x ON x.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 2)                                                         GROUP BY [union].union_name) x ON x.union_name = [union].union_name) b ON a.a = b.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 3)                                                         GROUP BY [union].union_name) x ON x.union_name = [union].union_name) c ON b.a = c.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 4)                                                         GROUP BY [union].union_name) x ON x.union_name = [union].union_name) d ON c.a = d.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 5)                                                         GROUP BY [union].union_name) x ON x.union_name = [union].union_name) e ON d.a = e.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 6)                                                         GROUP BY [union].union_name) x ON x.union_name = [union].union_name) f ON e.a = f.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, isnull(x.b, 0) AS c                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(member.member_id) AS b                                                         FROM          member INNER JOIN                                                                                relation ON member.relation_no = relation.relation_no INNER JOIN                                                                                khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (member.relation_no = 7)                                                         GROUP BY [union].union_name) x ON x.union_name = [union].union_name) g ON f.a = g.a";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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
            query1 = "SELECT     x.a AS status, x.b AS male, y.b AS female, ISNULL(x.b, 0) + ISNULL(y.b, 0) AS total FROM         (SELECT     marital_status.status AS a, ISNULL(a.b, 0) AS b                       FROM          marital_status LEFT OUTER JOIN                                                  (SELECT     marital_status.status, COUNT(member.member_id) AS b                                                    FROM          [union] INNER JOIN                                                                           cnc ON [union].union_id = cnc.union_id INNER JOIN                                                                           khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                           member INNER JOIN                                                                           marital_status ON member.marital_no = marital_status.marital_no ON khana.khana_id = member.khana_id INNER JOIN                                                                           thana ON [union].thana_id = thana.thana_id                                                    WHERE      (member.sex_no = 1) AND (thana.thana_name = '" + Thana_name + "')                                                    GROUP BY marital_status.status) a ON a.status = marital_status.status) x INNER JOIN                          (SELECT     marital_status.status AS a, ISNULL(a.b, 0) AS b                            FROM          marital_status LEFT OUTER JOIN                                                       (SELECT     marital_status.status, COUNT(member.member_id) AS b                                                         FROM          [union] INNER JOIN                                                                                cnc ON [union].union_id = cnc.union_id INNER JOIN                                                                                khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                member INNER JOIN                                                                                marital_status ON member.marital_no = marital_status.marital_no ON khana.khana_id = member.khana_id INNER JOIN                                                                                thana ON [union].thana_id = thana.thana_id                                                         WHERE      (member.sex_no = 2) AND (thana.thana_name = '" + Thana_name + "')                                                         GROUP BY marital_status.status) a ON a.status = marital_status.status) y ON x.a = y.a";

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

            query1 = "SELECT     a.occupation AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM         (SELECT     occupation, SUM(p) AS b                       FROM          (SELECT     occupation.occupation, ISNULL(a.b, 0) AS p   FROM          occupation LEFT OUTER JOIN (SELECT     occupation.occupation, occupation.occupation_no, COUNT(member.member_id) AS b       FROM          member INNER JOIN     occupation ON member.occupation_no = occupation.occupation_no INNER JOIN      khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                   cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   thana ON [union].thana_id = thana.thana_id                                                                            WHERE      (member.sex_no = 1) AND (member.age > 10) AND thana_name = '" + Thana_name + "'  GROUP BY occupation.occupation, occupation.occupation_no) a ON a.occupation_no = occupation.occupation_no)                     DERIVEDTBL                       GROUP BY occupation) a LEFT OUTER JOIN                          (SELECT     occupation, SUM(p) AS b                            FROM          (SELECT     occupation.occupation, ISNULL(a.b, 0) AS p                                                    FROM          occupation LEFT OUTER JOIN                                                                               (SELECT     occupation.occupation, occupation.occupation_no, COUNT(member.member_id) AS b                                                                                 FROM          member INNER JOIN                                                                                                        occupation ON member.occupation_no = occupation.occupation_no INNER JOIN                                                                                                        khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        thana ON [union].thana_id = thana.thana_id                                                                                 WHERE      (member.sex_no = 2) AND (member.age > 10) AND thana_name = '" + Thana_name + "'      GROUP BY occupation.occupation, occupation.occupation_no) a ON a.occupation_no = occupation.occupation_no)                                                    DERIVEDTBL                            GROUP BY occupation) b ON a.occupation = b.occupation";
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

            query1 = "SELECT     a.occupation AS litercystatus, a.b AS male, b.b AS female, ISNULL(a.b, 0) + ISNULL(b.b, 0) AS total FROM         (SELECT     occupation, SUM(p) AS b                       FROM          (SELECT     occupation.occupation, ISNULL(a.b, 0) AS p                                               FROM          occupation LEFT OUTER JOIN                                                                          (SELECT     occupation.occupation, occupation.occupation_no, COUNT(member.member_id) AS b                                                                            FROM          member INNER JOIN                                                                                                   occupation ON member.occupation_no = occupation.occupation_no INNER JOIN                                                                                                   khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                   cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   thana ON [union].thana_id = thana.thana_id                                                                            WHERE      (member.sex_no = 1) AND (member.relation_no = 1) AND thana_name = '" + Thana_name + "'                                                                           GROUP BY occupation.occupation, occupation.occupation_no) a ON a.occupation_no = occupation.occupation_no)                                               DERIVEDTBL                       GROUP BY occupation) a LEFT OUTER JOIN                          (SELECT     occupation, SUM(p) AS b                            FROM          (SELECT     occupation.occupation, ISNULL(a.b, 0) AS p                                                    FROM          occupation LEFT OUTER JOIN                                                                               (SELECT     occupation.occupation, occupation.occupation_no, COUNT(member.member_id) AS b                                                                                 FROM          member INNER JOIN                                                                                                        occupation ON member.occupation_no = occupation.occupation_no INNER JOIN                                                                                                        khana ON member.khana_id = khana.khana_id INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        thana ON [union].thana_id = thana.thana_id                                                                                 WHERE      (member.sex_no = 2) AND (member.relation_no = 1) AND thana_name = '" + Thana_name + "'                                                                                 GROUP BY occupation.occupation, occupation.occupation_no) a ON a.occupation_no = occupation.occupation_no)                                                    DERIVEDTBL                            GROUP BY occupation) b ON a.occupation = b.occupation";
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

            query1 = "SELECT     a1.unionname, a1.khana AS [<5], a2.khana AS [5-6], a3.khana AS [7-8], a4.khana AS [9-10], a5.khana AS [11+], ISNULL(a1.khana, 0) + ISNULL(a2.khana,                       0) + ISNULL(a3.khana, 0) + ISNULL(a4.khana, 0) + ISNULL(a5.khana, 0) AS total FROM         (SELECT     [union].union_name AS unionname, ISNULL(p.khana, 0) AS khana                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     union_name, isnull(COUNT(b), 0) AS khana                                                    FROM          (SELECT     [union].union_name, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                            FROM          khana INNER JOIN                                                                                                   cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   member ON khana.khana_id = member.khana_id                                                                            GROUP BY [union].union_name, khana.khana_id                                                                            HAVING      (COUNT(member.member_id) < 5)) DERIVEDTBL                                                    GROUP BY union_name) p ON p.union_name = [union].union_name) a1 LEFT OUTER JOIN                          (SELECT     [union].union_name AS unionname, ISNULL(p.khana, 0) AS khana                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, isnull(COUNT(b), 0) AS khana                                                         FROM          (SELECT     [union].union_name, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          khana INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 GROUP BY [union].union_name, khana.khana_id                                                                                 HAVING      (COUNT(member.member_id) BETWEEN 5 AND 6)) DERIVEDTBL                                                         GROUP BY union_name) p ON p.union_name = [union].union_name) a2 ON a1.unionname = a2.unionname LEFT OUTER JOIN                          (SELECT     [union].union_name AS unionname, ISNULL(p.khana, 0) AS khana                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, isnull(COUNT(b), 0) AS khana                                                         FROM          (SELECT     [union].union_name, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          khana INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 GROUP BY [union].union_name, khana.khana_id                                                                                 HAVING      (COUNT(member.member_id) BETWEEN 7 AND 8)) DERIVEDTBL                                                         GROUP BY union_name) p ON p.union_name = [union].union_name) a3 ON a2.unionname = a3.unionname LEFT OUTER JOIN                          (SELECT     [union].union_name AS unionname, ISNULL(p.khana, 0) AS khana                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, isnull(COUNT(b), 0) AS khana                                                         FROM          (SELECT     [union].union_name, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          khana INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 GROUP BY [union].union_name, khana.khana_id                                                                                 HAVING      (COUNT(member.member_id) BETWEEN 9 AND 10)) DERIVEDTBL                                                         GROUP BY union_name) p ON p.union_name = [union].union_name) a4 ON a3.unionname = a4.unionname LEFT OUTER JOIN                          (SELECT     [union].union_name AS unionname, ISNULL(p.khana, 0) AS khana                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, isnull(COUNT(b), 0) AS khana                                                         FROM          (SELECT     [union].union_name, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          khana INNER JOIN                                                                                                        cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 GROUP BY [union].union_name, khana.khana_id                                                                                 HAVING      (COUNT(member.member_id) > 11)) DERIVEDTBL                                                         GROUP BY union_name) p ON p.union_name = [union].union_name) a5 ON a4.unionname = a5.unionname";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];
                        row[5] = r[5];
                        row[6] = r[6];

                        data_set.Table10.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }
        private void set_11()
        {

            ds = new DataSet();
            dt = new DataTable();
            query1 = string.Empty;
            query2 = string.Empty;

            query1 = "SELECT     a1.a AS unionname, a1.b AS pacca, a2.b AS tin, a3.b AS [straw/bamboo], a4.b AS earth, a5.b AS others, ISNULL(a1.b, 0) + ISNULL(a2.b, 0) + ISNULL(a3.b, 0) + ISNULL(a4.b, 0) + ISNULL(a5.b, 0) AS total "
                    + " FROM         (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                    + "     FROM          [union] LEFT OUTER JOIN"
                        + "                            (SELECT     a AS union_name, COUNT(c) AS b"
                            + "                          FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                + "                                              FROM          cnc INNER JOIN"
                                    + "                                                                 khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                        + "                                                             roof ON khana.roof_no = roof.roof_no INNER JOIN"
                                            + "                                                         [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                                + "                                                     member ON khana.khana_id = member.khana_id"
                                                    + "                          WHERE      (khana.roof_no = 1)"
                                                        + "                      GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                     + " GROUP BY a) x ON [union].union_name = x.union_name) a1 LEFT OUTER JOIN"
                           + " (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                             + " FROM          [union] LEFT OUTER JOIN"
                                 + "                        (SELECT     a AS union_name, COUNT(c) AS b"
                                     + "                      FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                         + "                                          FROM          cnc INNER JOIN"
                                             + "                                                             khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                                 + "                                                         roof ON khana.roof_no = roof.roof_no INNER JOIN"
                                                     + "                                                     [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                                         + "                                                 member ON khana.khana_id = member.khana_id"
                                                             + "                      WHERE      (khana.roof_no = 2)"
                                                                 + "                  GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                          + "  GROUP BY a) x ON [union].union_name = x.union_name) a2 ON a1.a = a2.a LEFT OUTER JOIN"
                           + " (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                             + " FROM          [union] LEFT OUTER JOIN"
                                 + "                        (SELECT     a AS union_name, COUNT(c) AS b"
                                     + "                      FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                         + "                                          FROM          cnc INNER JOIN"
                                             + "                                                             khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                                 + "                                                         roof ON khana.roof_no = roof.roof_no INNER JOIN"
                                                     + "                                                     [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                                         + "                                                 member ON khana.khana_id = member.khana_id"
                                                             + "                      WHERE      (khana.roof_no = 3)"
                                                                 + "                  GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                          + " GROUP BY a) x ON [union].union_name = x.union_name) a3 ON a2.a = a3.a LEFT OUTER JOIN"
                           + " (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                             + " FROM          [union] LEFT OUTER JOIN"
                                 + "                        (SELECT     a AS union_name, COUNT(c) AS b"
                                     + "                      FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                         + "                                          FROM          cnc INNER JOIN"
                                             + "                                                             khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                                 + "                                                         roof ON khana.roof_no = roof.roof_no INNER JOIN"
                                                     + "                                                     [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                                         + "                                                 member ON khana.khana_id = member.khana_id"
                                                             + "                      WHERE      (khana.roof_no = 4)"
                                                                 + "                  GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                          + " GROUP BY a) x ON [union].union_name = x.union_name) a4 ON a3.a = a4.a LEFT OUTER JOIN"
                           + " (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                             + " FROM          [union] LEFT OUTER JOIN"
                                 + "                        (SELECT     a AS union_name, COUNT(c) AS b"
                                     + "                      FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                         + "                                          FROM          cnc INNER JOIN"
                                             + "                                                             khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                                 + "                                                         roof ON khana.roof_no = roof.roof_no INNER JOIN"
                                                     + "                                                     [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                                         + "                                                 member ON khana.khana_id = member.khana_id"
                                                             + "                      WHERE      (khana.roof_no = 5)"
                                                                 + "                  GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                          + " GROUP BY a) x ON [union].union_name = x.union_name) a5 ON a4.a = a5.a";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a1.a AS unionname, a1.b AS pacca, a2.b AS tin, a3.b AS [straw/bamboo], a4.b AS earth, a5.b AS others, ISNULL(a1.b, 0) + ISNULL(a2.b, 0)       + ISNULL(a3.b, 0) + ISNULL(a4.b, 0) + ISNULL(a5.b, 0) AS total FROM         (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                       + " FROM          [union] LEFT OUTER JOIN"
                         + "                         (SELECT     a AS union_name, COUNT(c) AS b"
                           + "                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                             + "                                               FROM          cnc INNER JOIN"
                               + "                                                                    khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                 + "                                                                  wall ON khana.wall_no = wall.wall_no INNER JOIN"
                                   + "                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                     + "                                                              member ON khana.khana_id = member.khana_id"
                                       + "                                     WHERE      (khana.wall_no = 1)"
                                         + "                                   GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                           + "         GROUP BY a) x ON [union].union_name = x.union_name) a1 LEFT OUTER JOIN"
                          + " (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                            + " FROM          [union] LEFT OUTER JOIN"
                              + "                         (SELECT     a AS union_name, COUNT(c) AS b"
                                + "                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                  + "                                               FROM          cnc INNER JOIN"
                                    + "                                                                    khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                      + "                                                                  wall ON khana.wall_no = wall.wall_no INNER JOIN"
                                        + "                                                                [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                          + "                                                              member ON khana.khana_id = member.khana_id"
                                            + "                                     WHERE      (khana.wall_no = 2)"
                                              + "                                   GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                + "         GROUP BY a) x ON [union].union_name = x.union_name) a2 ON a1.a = a2.a LEFT OUTER JOIN"
                          + " (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                            + " FROM          [union] LEFT OUTER JOIN"
                              + "                         (SELECT     a AS union_name, COUNT(c) AS b"
                              + "                            FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                 + "                                                 FROM          cnc INNER JOIN"
                                    + "                                                                     khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                       + "                                                                  wall ON khana.wall_no = wall.wall_no INNER JOIN"
                                          + "                                                               [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                             + "                                                            member ON khana.khana_id = member.khana_id"
                                                + "                                  WHERE      (khana.wall_no = 3)"
                                                   + "                               GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                      + "    GROUP BY a) x ON [union].union_name = x.union_name) a3 ON a2.a = a3.a LEFT OUTER JOIN"
                          + " (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                            + " FROM          [union] LEFT OUTER JOIN"
                               + "                         (SELECT     a AS union_name, COUNT(c) AS b"
                                  + "                        FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                     + "                                             FROM          cnc INNER JOIN"
                                        + "                                                                 khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                           + "                                                              wall ON khana.wall_no = wall.wall_no INNER JOIN"
                                              + "                                                           [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                                 + "                                                        member ON khana.khana_id = member.khana_id"
                                                    + "                              WHERE      (khana.wall_no = 4)"
                                                       + "                           GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                         + " GROUP BY a) x ON [union].union_name = x.union_name) a4 ON a3.a = a4.a LEFT OUTER JOIN"
                          + " (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b"
                            + " FROM          [union] LEFT OUTER JOIN"
                               + "                         (SELECT     a AS union_name, COUNT(c) AS b"
                                  + "                        FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c"
                                     + "                                             FROM          cnc INNER JOIN"
                                        + "                                                                 khana ON cnc.cnc_id = khana.cnc_id INNER JOIN"
                                           + "                                                              wall ON khana.wall_no = wall.wall_no INNER JOIN"
                                              + "                                                           [union] ON cnc.union_id = [union].union_id INNER JOIN"
                                                 + "                                                        member ON khana.khana_id = member.khana_id"
                                                    + "                              WHERE      (khana.wall_no = 5)"
                                                       + "                           GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL"
                                                         + " GROUP BY a) x ON [union].union_name = x.union_name) a5 ON a4.a = a5.a";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = " SELECT     a1.a AS unionname, a1.b AS pacca, a2.b AS tin, a3.b AS [straw/bamboo], a4.b AS earth, a5.b AS others, ISNULL(a1.b, 0) + ISNULL(a2.b, 0)                + ISNULL(a3.b, 0) + ISNULL(a4.b, 0) + ISNULL(a5.b, 0) AS total FROM (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b     FROM [union] LEFT OUTER JOIN                                                  (SELECT     a AS union_name, COUNT(c) AS b                                                    FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                            FROM          cnc INNER JOIN                                                                                                    khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                   floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   member ON khana.khana_id = member.khana_id                                                                            WHERE      (khana.floor_no = 1)                                                                            GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL                                                    GROUP BY a) x ON [union].union_name = x.union_name) a1 LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_name, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                  WHERE      (khana.floor_no = 2)                                                                                 GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_name = x.union_name) a2 ON a1.a = a2.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_name, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 WHERE      (khana.floor_no = 3)                                                                                 GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_name = x.union_name) a3 ON a2.a = a3.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_name, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 WHERE      (khana.floor_no = 4)                                                                                 GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) x ON [union].union_name = x.union_name) a4 ON a3.a = a4.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(x.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_name, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        floor ON khana.floor_no = floor.floor_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 WHERE      (khana.floor_no = 5)                                                                                 GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL    GROUP BY a) x ON [union].union_name = x.union_name) a5 ON a4.a = a5.a";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [<5000], b.y AS [5000-9999], c.y AS [10000-14999], d.y AS [15000-19999], e.y AS [20000-24999], f.y AS [25000-49999],"
                      + "g.y AS [50000+], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) + ISNULL(e.y, 0) + ISNULL(f.y, 0) + ISNULL(g.y, 0) AS total"
                  + "    FROM (SELECT   [union].union_name AS x, ISNULL(a.y, 0) AS y"
                       + " FROM          [union] LEFT OUTER JOIN"
                         + "                         (SELECT     union_name, COUNT(khana_id) AS y"
                         + "                           FROM          khana INNER JOIN"
                           + "                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN"
                             + "                                              [union] ON cnc.union_id = [union].union_id"
                               + "                     WHERE      (khana.house_price < 5000)"
                                 + "                   GROUP BY union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN"
                          + " (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y"
                            + " FROM          [union] LEFT OUTER JOIN"
                              + "                         (SELECT     union_name, COUNT(khana_id) AS y"
                                + "                         FROM          khana INNER JOIN"
                                  + "                                              cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN"
                                    + "                                            [union] ON cnc.union_id = [union].union_id"
                                      + "                   WHERE      (khana.house_price BETWEEN 5000 AND 9999)"
                                        + "                 GROUP BY union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN"
                          + " (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y"
                            + " FROM          [union] LEFT OUTER JOIN"
                              + "                         (SELECT     union_name, COUNT(khana_id) AS y"
                                + "                         FROM          khana INNER JOIN"
                                  + "                                              cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN"
                                    + "                                            [union] ON cnc.union_id = [union].union_id"
                                      + "                   WHERE      (khana.house_price BETWEEN 10000 AND 14999)"
                                        + "                 GROUP BY union_name) a ON a.union_name = [union].union_name) g RIGHT OUTER JOIN"
                          + " (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y"
                            + " FROM          [union] LEFT OUTER JOIN"
                              + "                         (SELECT     union_name, COUNT(khana_id) AS y"
                                + "                         FROM          khana INNER JOIN"
                                  + "                                              cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN"
                                    + "                                            [union] ON cnc.union_id = [union].union_id"
                                      + "                   WHERE      (khana.house_price BETWEEN 15000 AND 19999)"
                                        + "                 GROUP BY union_name) a ON a.union_name = [union].union_name) f ON g.x = f.x RIGHT OUTER JOIN"
                          + " (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y"
                            + " FROM          [union] LEFT OUTER JOIN"
                              + "                         (SELECT     union_name, COUNT(khana_id) AS y"
                                + "                         FROM          khana INNER JOIN"
                                  + "                                              cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN"
                                    + "                                            [union] ON cnc.union_id = [union].union_id"
                                      + "                   WHERE      (khana.house_price BETWEEN 20000 AND 24999)"
                                        + "                 GROUP BY union_name) a ON a.union_name = [union].union_name) e ON f.x = e.x RIGHT OUTER JOIN"
                          + " (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y"
                            + " FROM          [union] LEFT OUTER JOIN"
                              + "                         (SELECT     union_name, COUNT(khana_id) AS y"
                                + "                         FROM          khana INNER JOIN"
                                  + "                                              cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN"
                                    + "                                            [union] ON cnc.union_id = [union].union_id"
                                      + "                   WHERE      (khana.house_price BETWEEN 25000 AND 49000)"
                                        + "                 GROUP BY union_name) a ON a.union_name = [union].union_name) d ON e.x = d.x RIGHT OUTER JOIN"
                          + " (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y"
                            + " FROM          [union] LEFT OUTER JOIN"
                              + "                         (SELECT     union_name, COUNT(khana_id) AS y"
                                + "         FROM          khana INNER JOIN"
                                  + "       cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN"
                                    + "     [union] ON cnc.union_id = [union].union_id"
                                      + "  WHERE      (khana.house_price > 50000)"
                                        + " GROUP BY union_name) a ON a.union_name = [union].union_name) c ON d.x = c.x ON b.x = c.x";

            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [no land], b.y AS [<.05], c.y AS [0.05 - 0.24], d.y AS [0.25 - 0.49], e.y AS [0.50 - 0.99], f.y AS [1.0 - 1.49], g.y AS [1.5-1.99],                       h.y AS [2+], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) + ISNULL(e.y, 0) + ISNULL(f.y, 0) + ISNULL(g.y, 0) + ISNULL(h.y, 0)                       AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     union_name, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.land_amount = 0)                                                    GROUP BY union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount < 5)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 5 AND 24)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 25 AND 49)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 50 AND 99)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) e ON d.x = e.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 100 AND 149)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) f ON e.x = f.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount BETWEEN 150 AND 199)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) g ON f.x = g.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_amount > 200)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) h ON g.x = h.x";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [<5000], b.y AS [5000-9999], c.y AS [10000-14999], d.y AS [15000-19999], e.y AS [20000-24999], f.y AS [25000-49999],           g.y AS [50000+], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) + ISNULL(e.y, 0) + ISNULL(f.y, 0) + ISNULL(g.y, 0) AS total FROM         (SELECT     [union].union_name x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     union_name, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.land_price < 5000)                                                    GROUP BY union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                        FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 5000 AND 9999)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 10000 AND 14999)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name x, ISNULL(a.y, 0) AS y                           FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 15000 AND 19999)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x LEFT OUTER JOIN                         (SELECT     [union].union_name x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 20000 AND 24999)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) e ON d.x = e.x LEFT OUTER JOIN                          (SELECT     [union].union_name x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price BETWEEN 25000 AND 49999)                                                        GROUP BY union_name) a ON a.union_name = [union].union_name) f ON e.x = f.x LEFT OUTER JOIN                          (SELECT     [union].union_name x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.land_price > 50000)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) g ON f.x = g.x";

            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS no, b.y AS [<5], c.y AS [5 - 10], d.y AS [11 - 15], e.y AS [16 - 20], f.y AS [20+], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0)                       + ISNULL(d.y, 0) + ISNULL(e.y, 0) + ISNULL(f.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.vegitable_land = 0)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land < 5)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                          FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land BETWEEN 5 AND 10)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land BETWEEN 11 AND 15)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land BETWEEN 16 AND 20)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) e ON d.x = e.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.vegitable_land > 20)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) f ON e.x = f.x";


            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [1-2], b.y AS [3 - 4], c.y AS [4+], d.y AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                 (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.cow BETWEEN 1 AND 2)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.cow BETWEEN 3 AND 4)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.cow > 4)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.cow = 0)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [1-2], b.y AS [3 - 4], c.y AS [4+], d.y AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.goat BETWEEN 1 AND 2)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.goat BETWEEN 3 AND 4)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.goat > 4)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.goat = 0)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x";

            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [1-2], b.y AS [3 - 4], c.y AS [4+], d.y AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.hen BETWEEN 1 AND 2)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.hen BETWEEN 3 AND 4)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.hen > 4)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.hen = 0)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [1-2], b.y AS [3 - 4], c.y AS [4+], d.y AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0) + ISNULL(d.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     union_name, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.fruit_tree BETWEEN 1 AND 2)                                                    GROUP BY union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.fruit_tree BETWEEN 3 AND 4)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.fruit_tree > 4)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.fruit_tree = 0)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x";
            query2 = "SELECT  [union].union_name FROM  thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [0 - 3], b.y AS [4 - 6], c.y AS [7 - 9], d.y AS [10 - 11], e.y AS [12], ISNULL(a.y, 0) + ISNULL(b.y, 0) + ISNULL(c.y, 0)    + ISNULL(d.y, 0) + ISNULL(e.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     union_name, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.month_covered < 3)                                                    GROUP BY union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.month_covered BETWEEN 4 AND 6)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.month_covered BETWEEN 7 AND 9)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.month_covered BETWEEN 10 AND 11)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x LEFT OUTER JOIN    (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y    FROM          [union] LEFT OUTER JOIN  (SELECT     union_name, COUNT(khana_id) AS y  FROM          khana INNER JOIN  cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN  [union] ON cnc.union_id = [union].union_id  WHERE (khana.month_covered = 12)   GROUP BY union_name) a ON a.union_name = [union].union_name) e ON d.x = e.x";

            query2 = "SELECT  [union].union_name FROM  thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], a.y AS [0 - 120], b.y AS [121 - 180], c.y AS [181 - 240], d.y AS [241 - 300], e.y AS [300+], ISNULL(a.y, 0) + ISNULL(b.y, 0)     + ISNULL(c.y, 0) + ISNULL(d.y, 0) + ISNULL(e.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     union_name, COUNT(khana_id) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.labour_days <= 120)                                                    GROUP BY union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.labour_days BETWEEN 121 AND 180)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.labour_days BETWEEN 181 AND 240)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) c ON b.x = c.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                               [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.labour_days BETWEEN 241 AND 300)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) d ON c.x = d.x LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     union_name, COUNT(khana_id) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.labour_days > 300)                                                         GROUP BY union_name) a ON a.union_name = [union].union_name) e ON d.x = e.x";
            query2 = "SELECT  [union].union_name FROM  thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                        FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.bed = 1)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.bed = 2)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x";

            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                        FROM          [union] LEFT OUTER JOIN                                               (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.chair = 1)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.chair = 2)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x";

            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                          [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.radio = 1)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.radio = 2)                                                       GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x";


            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = " SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.tv = 1)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.tv = 2)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x";


            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a.x AS [union name], ISNULL(a.y, 0) AS yes, ISNULL(b.y, 0) AS no, ISNULL(a.y, 0) + ISNULL(b.y, 0) AS total FROM         (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.tubewell = 1)                                                    GROUP BY [union].union_name) a ON a.union_name = [union].union_name) a LEFT OUTER JOIN                          (SELECT     [union].union_name AS x, ISNULL(a.y, 0) AS y                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, ISNULL(COUNT(khana.khana_id), 0) AS y                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.tubewell = 2)                                                         GROUP BY [union].union_name) a ON a.union_name = [union].union_name) b ON a.x = b.x";


            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     a1.a AS unionname, a1.b AS tubewell, a2.b AS well, a3.b AS ponds, a4.b AS others, ISNULL(a1.b, 0) + ISNULL(a2.b, 0) + ISNULL(a3.b, 0) + ISNULL(a4.b,                       0) AS total FROM         (SELECT     [union].union_name AS a, ISNULL(a.b, 0) AS b                       FROM          [union] LEFT OUTER JOIN                                                  (SELECT     a AS union_name, COUNT(c) AS b                                                    FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                            FROM          cnc INNER JOIN                                                                                                   khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                   roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                   [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                   member ON khana.khana_id = member.khana_id                                                                            WHERE      (khana.water_source_no = 1)                                                                            GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL                                                    GROUP BY a) a ON a.union_name = [union].union_name) a1 LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_name, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 WHERE      (khana.water_source_no = 2)                                                                                 GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) a ON a.union_name = [union].union_name) a2 ON a1.a = a2.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_name, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 WHERE      (khana.water_source_no = 3)                                                                                 GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) a ON a.union_name = [union].union_name) a3 ON a2.a = a3.a LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(a.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     a AS union_name, COUNT(c) AS b                                                         FROM          (SELECT     [union].union_name AS a, khana.khana_id AS b, COUNT(member.member_id) AS c                                                                                 FROM          cnc INNER JOIN                                                                                                        khana ON cnc.cnc_id = khana.cnc_id INNER JOIN                                                                                                        roof ON khana.roof_no = roof.roof_no INNER JOIN                                                                                                        [union] ON cnc.union_id = [union].union_id INNER JOIN                                                                                                        member ON khana.khana_id = member.khana_id                                                                                 WHERE      (khana.water_source_no = 4)                                                                                 GROUP BY [union].union_name, khana.khana_id) DERIVEDTBL                                                         GROUP BY a) a ON a.union_name = [union].union_name) a4 ON a3.a = a4.a    ";
            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     x.a AS unionname, x.b AS yes, y.b AS no, ISNULL(x.b, 0) + ISNULL(y.b, 0) AS total FROM         (SELECT     [union].union_name AS a, ISNULL(p.b, 0) AS b       FROM          [union] LEFT OUTER JOIN                                                   (SELECT     [union].union_name, COUNT(khana.khana_id) AS b                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.latrine = 1)                                                    GROUP BY [union].union_name) p ON [union].union_name = p.union_name) x LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(p.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS b                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.latrine = 2)                                                         GROUP BY [union].union_name) p ON [union].union_name = p.union_name) y ON x.a = y.a";

            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
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

            query1 = "SELECT     x.a AS unionname, x.b AS yes, y.b AS no, ISNULL(x.b, 0) + ISNULL(y.b, 0) AS total FROM         (SELECT     [union].union_name AS a, ISNULL(p.b, 0) AS b       FROM          [union] LEFT OUTER JOIN                                                   (SELECT     [union].union_name, COUNT(khana.khana_id) AS b                                                    FROM          khana INNER JOIN                                                                           cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                           [union] ON cnc.union_id = [union].union_id                                                    WHERE      (khana.latrine = 1)                                                    GROUP BY [union].union_name) p ON [union].union_name = p.union_name) x LEFT OUTER JOIN                          (SELECT     [union].union_name AS a, ISNULL(p.b, 0) AS b                            FROM          [union] LEFT OUTER JOIN                                                       (SELECT     [union].union_name, COUNT(khana.khana_id) AS b                                                         FROM          khana INNER JOIN                                                                                cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN                                                                                [union] ON cnc.union_id = [union].union_id                                                         WHERE      (khana.latrine = 2)                                                         GROUP BY [union].union_name) p ON [union].union_name = p.union_name) y ON x.a = y.a";

            query2 = "SELECT  [union].union_name FROM         thana INNER JOIN   [union] ON thana.thana_id = [union].thana_id WHERE     (thana.thana_name = '" + Thana_name + "') ";

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
                    DataColumn column1 = ds.Tables[1].Columns[0];
                    if (r[column].ToString() == r1[column1].ToString())
                    {
                        row[0] = r[0];
                        row[1] = r[1];
                        row[2] = r[2];
                        row[3] = r[3];


                        data_set.Table20.Rows.Add(row);
                    }
                }
            }

            //throw new NotImplementedException();
        }



        #endregion






        //public void set_report()
        // {
        //     Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
        //     System.Windows.Forms.BindingSource TableBindingSource;

        //     if (comboBox1.Text.Length != 0)
        //     {


        //         TableBindingSource = new BindingSource();
        //         string data_source = "DataSet2_" + comboBox1.Text.ToString();
        //         string name = comboBox1.Text.ToString();
        //         name = "ReportsApplication1." + name.ToString() + ".rdlc";



        //          TableBindingSource.DataMember = comboBox1.Text.ToString();
        //         //  TableBindingSource.DataSource = this.dataSet21;

        //       //  reportDataSource1.Name = "DataSet2_Table20";
        //         reportDataSource1.Name =data_source;
        //         reportDataSource1.Value = TableBindingSource;
        //         this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
        //         this.reportViewer1.LocalReport.ReportEmbeddedResource =name;


        //         //TableTableAdapter t.Fill(this.DataSet2.Table20);


        //         this.reportViewer1.Refresh();





        //         this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
        //         this.reportViewer1.LocalReport.ReportEmbeddedResource = name;




        //         //this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);




        //         this.reportViewer1.RefreshReport();
        //     }
        // }





        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            // this.reportViewer1.Refresh();
            // this.reportViewer1.LocalReport.DataSources.Clear();
            // set_report();
        }

        private void comboBox_Thana_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Report y = new Report(data_set);
           // y.Show();
        }







    }
}