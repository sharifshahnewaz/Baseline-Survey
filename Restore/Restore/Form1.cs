using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackEnd;


namespace Restore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Database db = new Database();
        //String s = "select * from khana";
        //String[,] khana = db.SelectColumns(s, "khana");

        int count_fail_Member = 0, count_insert_Member = 0, count_previous_Member = 0, count_current_Member = 0;
        int count_fail_Khana = 0, count_insert_Khana = 0, count_previous_Khana = 0, count_current_Khana = 0;
        int count_fail_CNC = 0, count_insert_CNC = 0, count_previous_CNC = 0, count_current_CNC = 0;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void button_Reastore_Click(object sender, EventArgs e)
        {
            set_Cnc_table();
            set_Khana_table();
            set_Manmber_table();

          //  MessageBox.Show("   CNC   \nPrevious "+count_previous_CNC+"\nInsert : "+count_insert_CNC+"\n Fail :"+count_fail_CNC+"\nCurrent : "+count_current_CNC+";","Report");
           // MessageBox.Show("   Khan  \nPrevious " + count_previous_Khana + "\nInsert : " + count_insert_Khana + "\n Fail :" + count_fail_Khana + "\nCurrent : " + count_current_Khana + ";", "Report");
            //MessageBox.Show("   Member\nPrevious " + count_previous_Member + "\nInsert : " + count_insert_Member + "\n Fail :" + count_fail_Member + "\nCurrent : " + count_current_Member + ";", "Report");
            previous_cnc.Visible = true;
            previous_cnc.Text="Previous CNC :  "+count_previous_CNC+"";
            cnc_added.Visible = true;
            cnc_added.Text=   "Added CNC :     "+count_insert_CNC+"";
            fail_cnc.Visible = true;
            fail_cnc.Text=    "Failed CNC :      "+count_fail_CNC+"";
            current_cnc.Visible = true;
            current_cnc.Text="Current CNC :     "+count_current_CNC+"";

            khana_previous.Visible = true;
            khana_previous.Text="Previous Khana : "+count_previous_Khana+"";
            khana_added.Visible = true;
            khana_added.Text="Added Khana  :  "+count_insert_Khana+"";
            khana_fail.Visible = true;
            khana_fail.Text="Failed Khana  :  "+count_fail_Khana+"";
            khana_current.Visible = true;
            khana_current.Text="Current khana : "+count_current_Khana+"";

            member_previous.Visible = true;
            member_previous.Text = "Previous Member : " + count_previous_Member + "";
            member_added.Visible = true;
            member_added.Text = "Added Member :   " + count_insert_Member + "";
            member_fail.Visible = true;
            member_fail.Text = "Failed Member :    " + count_fail_Member + "";
            member_current.Visible = true;
            member_current.Text = "Current Member : " + count_current_Member + "";
            button_Reastore.Visible = false;
            done.Visible = true;

        }

        private void set_Manmber_table()
        {
            count_current_Member = 0;
            count_previous_Member = 0;
            count_insert_Member = 0;
            count_fail_Member = 0;
            #region Temp
            Database db = new Database();
            string query = "select * from member";
            DataTable dt = db.return_dataset(query);
            #endregion

            #region Main
            db = new Database("Data Source=(LOCAL);Initial Catalog=baselineMaster;User ID = sa;Password =");
            query = "select * from member";
            DataTable dt_m = db.return_dataset(query);
            #endregion


            int Flag;

            

            count_previous_Member = dt_m.Rows.Count;
            foreach (DataRow r in dt.Rows)
            {

                Flag = 0;
                foreach (DataRow r1 in dt_m.Rows)
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
                        "'," + r[6] + "," + r[7] + "," + r[8] + "," + r[9] + "," + r[10] + "," + r[11] +   "," + r[12] + ",'" + r[13] + "','" + r[14] + "'," + r[15] + ")";
                    if (!db.Insert(query))
                    {
                        MessageBox.Show("Failed to insert");
                        count_fail_Member++;
                    }
                    else
                        count_insert_Member++;
                }

            }

            count_current_Member = count_previous_Member + count_insert_Member;           

        }

        private void set_Khana_table()
        {

            count_current_Khana = 0;
            count_previous_Khana = 0;
            count_insert_Khana = 0;
            count_fail_Khana = 0;
            #region Temp
            Database db = new Database();
            string query = "select * from khana";
            DataTable dt = db.return_dataset(query);
            #endregion

            #region Main
            db = new Database("Data Source=(LOCAL);Initial Catalog=baselineMaster;User ID = sa;Password =");
            query = "select * from Khana";
            DataTable dt_m = db.return_dataset(query);
            #endregion


            int Flag;

            

            count_previous_Khana = dt_m.Rows.Count;
            foreach (DataRow r in dt.Rows)
            {

                Flag = 0;
                foreach (DataRow r1 in dt_m.Rows)
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
                            + r[24] + "," + r[25] + "," + r[26] + ",'" + r[27] +"','" 
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

            count_current_Khana = count_previous_Khana + count_insert_Khana;           


        }

        private void set_Cnc_table()
        {

            count_current_CNC = 0;
            count_previous_CNC = 0;
            count_insert_CNC = 0;
            count_fail_CNC = 0;
            
            #region Temp
            Database db = new Database();
            string query = "select * from CNC";
            DataTable dt = db.return_dataset(query);
            #endregion

            #region Main
            db = new Database("Data Source=(LOCAL);Initial Catalog=baselineMaster;User ID = sa;Password =");
            query = "select * from CNC";
            DataTable dt_m = db.return_dataset(query);
            #endregion


            int Flag;

            

            count_previous_CNC = dt_m.Rows.Count;
            foreach(DataRow r in dt.Rows)
            {
                
                Flag = 0;
                foreach (DataRow r1 in dt_m.Rows)
                {

                    if (r[2].ToString() == r1[2].ToString())
                    {
                        Flag = 1;
                        
                    }

                }
                if (Flag == 0)
                {
                    query = "INSERT INTO cnc  (cnc_no, union_id, cnc_id) VALUES (" + r[0] + ",'" + r[1] + "','" + r[2] + "')";
                    if (!db.Insert(query))
                    {
                        MessageBox.Show("Failed to insert");
                        count_fail_CNC++;
                    }
                    else
                        count_insert_CNC++;
                }                
            }
            count_current_CNC = count_previous_CNC+count_insert_CNC;           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
