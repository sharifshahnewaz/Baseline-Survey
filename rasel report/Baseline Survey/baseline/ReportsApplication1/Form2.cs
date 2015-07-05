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
    public partial class Form2 : Form
    {
        DataSet2 data_set;
        public Form2(DataSet2 ds)
        {
            data_set = ds;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.Table18B' table. You can move, or remove it, as needed.
            //this.Table18BTableAdapter.Fill(this.DataSet2.Table18B);
            // TODO: This line of code loads data into the 'DataSet2.Table18C' table. You can move, or remove it, as needed.
          //  this.Table18CTableAdapter.Fill(this.DataSet2.Table18C);
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2_Table13", data_set.Table13));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table13.rdlc";
            this.reportViewer1.RefreshReport();
            
            this.reportViewer1.RefreshReport();
        }

        private void Table12BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
