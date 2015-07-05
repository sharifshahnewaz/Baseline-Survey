using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BackEnd;
using System.Web;

namespace ReportsApplication1
{
    public partial class Report : Form
    {
        int flag = 1;
        DataSet2 data_set;
        //public Report(DataSet2 ds)
        //{
        //    data_set = ds;
        //    InitializeComponent();
        //}

        public Report()
        {
           
            InitializeComponent();

            restore_();
        }
        #region Database Exchange

        private void restore_()
        {
            set_Cnc_table();
            set_Khana_table();
            set_Manmber_table();
        }

        int count_fail_Member = 0, count_insert_Member = 0, count_previous_Member = 0, count_current_Member = 0;
        int count_fail_Khana = 0, count_insert_Khana = 0, count_previous_Khana = 0, count_current_Khana = 0;
        int count_fail_CNC = 0, count_insert_CNC = 0, count_previous_CNC = 0, count_current_CNC = 0;

        private void set_Cnc_table()
        {
            #region Main
            Database db = new Database("Data Source=(LOCAL);Initial Catalog=baselineMaster;User ID = sa;Password =");
            string query = "select * from CNC";
            DataTable dt_m = db.return_dataset(query);
            #endregion


            #region Temp
             db = new Database();
             query = "select * from CNC";
            DataTable dt = db.return_dataset(query);
            #endregion          
            int Flag;



            count_previous_CNC = dt_m.Rows.Count;
            foreach (DataRow r1 in dt_m.Rows)
            {

                Flag = 0;
                foreach (DataRow r in dt.Rows)
                {

                    if (r1[2].ToString() == r[2].ToString())
                    {
                        Flag = 1;

                    }

                }
                if (Flag == 0)
                {
                    query = "INSERT INTO cnc  (cnc_no, union_id, cnc_id) VALUES (" + r1[0] + ",'" + r1[1] + "','" + r1[2] + "')";
                    if (!db.Insert(query))
                    {
                        MessageBox.Show("Failed to insert");
                        count_fail_CNC++;
                    }
                    else
                        count_insert_CNC++;
                }
            }
            count_current_CNC += count_previous_CNC;


        }
        private void set_Khana_table()
        {
            #region Main
            Database db = new Database("Data Source=(LOCAL);Initial Catalog=baselineMaster;User ID = sa;Password =");
            string query = "select * from Khana";
            DataTable dt_m = db.return_dataset(query);
            #endregion


            #region Temp
            db = new Database();
            query = "select * from khana";
            DataTable dt = db.return_dataset(query);
            #endregion     


            int Flag;



            count_previous_Khana = dt_m.Rows.Count;
            foreach (DataRow r in dt_m.Rows)
            {

                Flag = 0;
                foreach (DataRow r1 in dt.Rows)
                {

                    if (r[30].ToString() == r1[30].ToString())
                    {
                        Flag = 1;

                    }

                }
                if (Flag == 0)
                {

                    query = "INSERT INTO khana ( khana_no,cnc_id,user_id,roof_no,wall_no,floor_no,water_source_no,evaluation_no,house_price,land_amount,land_price,cow,goat,hen,fruit_tree,vegitable_land,month_covered,bed,chair,radio,tv,tubewell,milky_cow,milky_goat,day_labourer,labour_days,latrine,enumerator,cno_name,entry_date, khana_id) VALUES ("
                             + r[0] + ",'" + r[1] + "','" + r[2] + "'," + r[3] + "," + r[4] + ","
                             + r[5] + "," + r[6] + "," + r[7] + "," + r[8] + ","
                             + r[9] + "," + r[10] + "," + r[11] + "," + r[12] + "," + r[13] + ","
                             + r[14] + "," + r[15] + "," + r[16] + "," + r[17] + "," + r[18] + ","
                             + r[19] + "," + r[20] + "," + r[21] + "," + r[22] + "," + r[23] + ","
                             + r[24] + "," + r[25] + "," + r[26] + ",'" + r[27] + "','"
                             + r[28] + "','" + r[29] + "','" + r[30] + "')";

                    if (!db.Insert(query))
                    {
                        MessageBox.Show("Failed to insert");
                        count_fail_Khana++;
                    }
                    else
                        count_insert_Khana++;
                }

            }

            count_current_Khana += count_previous_Khana;


        }
        private void set_Manmber_table()
        {
            #region Main
            Database db = new Database("Data Source=(LOCAL);Initial Catalog=baselineMaster;User ID = sa;Password =");
            string query = "select * from Member";
            DataTable dt_m = db.return_dataset(query);
            #endregion


            #region Temp
            db = new Database();
            query = "select * from member";
            DataTable dt = db.return_dataset(query);
            #endregion     


            int Flag;



            count_previous_Member = dt_m.Rows.Count;
            foreach (DataRow r in dt_m.Rows)
            {

                Flag = 0;
                foreach (DataRow r1 in dt.Rows)
                {

                    if (r[14].ToString() == r1[14].ToString())
                    {
                        Flag = 1;

                    }

                }
                if (Flag == 0)
                {

                    query = "INSERT INTO member (member_no, mother_no, name, relation_no, age, dob, sex_no, marital_no, marital_year, education_no, weight, height, parity, khana_id, member_id, occupation_no)"
                        + "VALUES (" + r[0] + "," + r[1] + ",'" + r[2] + "'," + r[3] + "," + r[4] + ",'" + r[5] +
                        "'," + r[6] + "," + r[7] + "," + r[8] + "," + r[9] + "," + r[10] + "," + r[11] + "," + r[12] + ",'" + r[13] + "','" + r[14] + "'," + r[15] + ")";
                    if (!db.Insert(query))
                    {
                        MessageBox.Show("Failed to insert");
                        count_fail_Member++;
                    }
                    else
                        count_insert_Member++;
                }

            }

            count_current_Member += count_previous_Member;

        }

        #endregion 




        private void set_thana_name()
        {
            BackEnd.Database data = new BackEnd.Database();
            string query = "SELECT     thana_name FROM         thana";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
           

            dt = data.return_dataset(query);
            ds.Tables.Add(dt);
            comboBox_Thana.DisplayMember = "Table1.Thana_Name";
            comboBox_Thana.DataSource = ds;

           // throw new NotImplementedException();
        }
        #region Repot Show
        public void view_1()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_1A()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1A", data_set.Table1A));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1A.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_2()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table2", data_set.Table2));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table2.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        
        public void view_3()
        {
            this.reportViewer1.Reset();
            this.reportViewer1.Refresh();               
            
            this.reportViewer1.LocalReport.DataSources.Clear();
                

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table_3.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table_3", data_set.Table_3));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table_3.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_4()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table4", data_set.Table4));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table4.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_5()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table5", data_set.Table5));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table5.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_6()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table6", data_set.Table6));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table6.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_7()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table7", data_set.Table7));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table7.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_8()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table8", data_set.Table8));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table8.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_9()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table9", data_set.Table9));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table9.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_10()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table10", data_set.Table10));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table10.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_11()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table11", data_set.Table11));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table11.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_11A()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table11A", data_set.Table11A));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table11A.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_11B()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table11B", data_set.Table11B));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table11B.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_12()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table12", data_set.Table12));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table12.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_13()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table13", data_set.Table13));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table13.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_13A()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table13A", data_set.Table13A));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table13A.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_13B()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table13B", data_set.Table13B));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table13B.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_14()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table14Cow", data_set.Table14Cow));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table14.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_14B()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table14Goat", data_set.Table14Goat));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table14B.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_14C()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table14Hen", data_set.Table14Hen));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table14C.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_15()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table15", data_set.Table15));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table15.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_16()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table16", data_set.Table16));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table16.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_17()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table17", data_set.Table17));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table17.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_18()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table18", data_set.Table18));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table18.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_18A()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table18A", data_set.Table18A));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table18A.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_18B()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table18B", data_set.Table18B));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table18B.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_18C()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table18C", data_set.Table18C));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table18C.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_18D()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table18D", data_set.Table18D));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table18D.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_19()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table19", data_set.Table19));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table19.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


        public void view_20()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table20", data_set.Table20));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table20.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_21()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table21", data_set.Table21));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table21.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_22()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table22", data_set.Table22));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table22.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        } 
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
       
           
            if (flag == 1)
            {
                view_1();
                flag++;
            }
            else if (flag == 2)
            {
                flag++;
            }
            else if (flag == 3)
            {
                view_3();
                flag++;
            }
            else if (flag == 4)
            {
                view_4();
                flag++;
            }


            else if (flag == 5)
            {
                view_5();
                flag++;
            }





        }

        string previous = string.Empty;
        private void button_Show_Click(object sender, EventArgs e)
        {
            if (comboBox_report.Text.ToString().Length != 0)
            {
                if (previous.Length == 0)
                {
                    previous = comboBox_Thana.Text.ToString();
                    reportgenerat report_show = new reportgenerat();
                    data_set = report_show.LoadData(comboBox_Thana.Text.ToString());
               
                }
                else if (previous != comboBox_Thana.Text.ToString())
                {
                    reportgenerat report_show = new reportgenerat();
                    data_set = report_show.LoadData(comboBox_Thana.Text.ToString());
                    previous = comboBox_Thana.Text.ToString();
                }
                
                string report = comboBox_report.Text.ToString();
                #region show report
                if (report == "Report 1")
                {
                    view_1();
                }
                else if (report == "Report 1A")
                {
                    view_1A();
                }
                else if (report == "Report 2")
                {
                    view_2();
                }
                else if (report == "Report 3")
                {
                    view_3();
                }
                else if (report == "Report 4")
                {
                    view_4();
                }
                else if (report == "Report 5")
                {
                    view_5();
                }
                else if (report == "Report 6")
                {
                    view_6();
                }
                else if (report == "Report 7")
                {
                    view_7();
                }
                else if (report == "Report 8")
                {
                    view_8();
                }
                else if (report == "Report 9")
                {
                    view_9();
                }
                else if (report == "Report 10")
                {
                    view_10();
                }
                else if (report == "Report 11")
                {
                    view_11();
                }
                else if (report == "Report 11A")
                {
                    view_11A();
                }
                else if (report == "Report 11B")
                {
                    view_11B();
                }
                else if (report == "Report 12")
                {
                    view_12();
                }
                else if (report == "Report 13")
                {
                    view_13();
                }
                else if (report == "Report 13A")
                {
                    view_13A();
                }
                else if (report == "Report 13B")
                {
                    view_13B();
                }
                else if (report == "Report 14")
                {
                    view_14();
                }
                else if (report == "Report 14B")
                {
                    view_14B();
                }
                else if (report == "Report 14C")
                {
                    view_14C();
                }
                else if (report == "Report 15")
                {
                    view_15();
                }
                else if (report == "Report 16")
                {
                    view_16();
                }
                else if (report == "Report 17")
                {
                    view_17();
                }
                else if (report == "Report 18")
                {
                    view_18();
                }
                else if (report == "Report 18A")
                {
                    view_18A();
                }
                else if (report == "Report 18B")
                {
                    view_18B();
                }
                else if (report == "Report 18C")
                {
                    view_18C();
                }
                else if (report == "Report 18D")
                {
                    view_18D();
                }
                else if (report == "Report 19")
                {
                    view_19();
                }
                else if (report == "Report 20")
                {
                    view_20();
                }
                else if (report == "Report 21")
                {
                    view_21();
                }
                else if (report == "Report 22")
                {
                    view_22();
                }


                #endregion

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Form1 form1 = new Form1();
            

        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        
            set_thana_name();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        
        }

        private void comboBox_report_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

    
    }
}
