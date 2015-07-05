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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1);
 

            this.reportViewer1.RefreshReport();
            load_value();
            
            
        }

        private void load_value()
        {
            BackEnd.Database database = new BackEnd.Database();


            string query = string.Empty;
            string []s = new string[100];  
            query = "SELECT     union_id FROM         [union]";
            s = database.SelectSingleColumn(query, "union");

            int i = 0;
            DataSet data_set = new DataSet();
            #region SetValue
            while (s[i]!=null)
            {
                DataRow data = data_set.Union.NewRow();
                string union_id = string.Empty;
                union_id = s[i].ToString();
                query = "SELECT     union_no FROM         [union] where union_id = '" + union_id+"'";
                int union_no = database.SelectInt(query);
                

                
                query =  "SELECT     COUNT(member.member_no)FROM         member INNER JOIN  khana ON member.khana_id = khana.khana_id INNER JOIN  cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN   [union] ON cnc.union_id = [union].union_id    WHERE     ([union].union_id = '"+union_id+"') AND (member.sex_no = 1)";            


                int male = database.SelectInt(query);
                query = "SELECT     COUNT(member.member_no)FROM         member INNER JOIN  khana ON member.khana_id = khana.khana_id INNER JOIN  cnc ON khana.cnc_id = cnc.cnc_id INNER JOIN   [union] ON cnc.union_id = [union].union_id    WHERE     ([union].union_id = '" + union_id + "') AND (member.sex_no = 2)";

                int Female = database.SelectInt(query);
                data[0] = union_no.ToString();
                data[1] = male.ToString();
                data[2] = Female.ToString();
                data_set.Union.Rows.Add(data);
                i++;
            }
            #endregion

            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Union",data_set.Union));
         //   this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Report1.rdlc";
            this.reportViewer1.RefreshReport();




        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
}
