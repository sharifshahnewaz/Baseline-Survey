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


namespace ReportsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1);
            // TODO: This line of code loads data into the 'DataSet2.Table8' table. You can move, or remove it, as needed.
            this.Table8TableAdapter.Fill(this.DataSet2.Table8);
          
            LoadData();
            this.reportViewer1.RefreshReport();
        }

        private void LoadData()
        {
            //DataSet data = new DataSet();
            //for(int i = 0;i<10;i++)
            //{
            //    DataRow r = data.Union.NewRow();
            //    r[0] = 50 + i * 13;
            //    r[1] = 70 + i * 7;
            //    data.Union.Rows.Add(r);
            //}
            //this.reportViewer1.Refresh();
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Union", data.Union));
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Report1.rdlc";
            //this.reportViewer1.RefreshReport();
           
        }

      




       public void set_report()
        {
            if (comboBox1.Text.Length != 0)
            {
                string name = comboBox1.Text.ToString();

                name = "ReportsApplication1." + name.ToString() + ".rdlc";

                string data_source = "DataSet2_" + comboBox1.Text.ToString();

               // this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(data_source, DataSet2.Table1));
                this.reportViewer1.LocalReport.ReportEmbeddedResource = name;




                this.reportViewer1.RefreshReport();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();


            set_report();

           

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            
           set_report();
                
                this.reportViewer1.RefreshReport();
            }

        

       

    }
}