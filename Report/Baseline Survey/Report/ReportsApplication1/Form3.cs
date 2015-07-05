using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ReportsApplication1
{
    public partial class Form3 : Form
    {
        int flag = 1;
        DataSet2 data_set;
        public Form3(DataSet2 ds)
        {
            data_set = ds;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
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

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table4", data_set.Table4));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table4.rdlc";
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

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_10()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_11()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_11A()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_11B()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_12()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_13()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_13A()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_14()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_14A()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_14B()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_14C()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_15()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_16()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_17()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_18()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_18A()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_18B()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_18C()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_18D()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void view_19()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


        public void view_20()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void view_21()
        {
            reportViewer1.Reset();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table1", data_set.Table1));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table1.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

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
    }
}
