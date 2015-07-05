using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackEnd;

namespace baseline
{
    public partial class MainForm : Form
    {
        public static  int i=0;
        public String userid = null;
        public MainForm()
        {
            InitializeComponent();
            District d = new District();
            districtbox.DataSource = d.getDistrictList();      
      
            
            
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            userbox.Visible = true ;
            username.Visible = true ;
            passwordbox.Visible = true ;
            password.Visible = true ;
            login.Visible = true ;
            logout.Visible = false ;
            tabControl1.Visible = false ;
            membercountbox.Visible = false;
            membercountlabel.Visible = false;
            khanacounlabel.Visible = false;
            khanacountbox.Visible = false;
            userbox.Clear();
            passwordbox.Clear();
            
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void input_Click(object sender, EventArgs e)
        {
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            User u = new User();
            userid = userbox.Text;
            //if (u.getPassword(userbox.Text.ToString()) == passwordbox.Text.ToString())
          //  {
                userbox.Visible = false;
                username.Visible = false;
                passwordbox.Visible = false;
                password.Visible = false;
                login.Visible = false;
                logout.Visible = true;
                tabControl1.Visible = true;
                membercountbox.Visible = true;
                membercountlabel.Visible = true;
                khanacounlabel.Visible = true;
                khanacountbox.Visible = true;
                khanacountbox.Text = u.getKhanaCount(userid).ToString();
                membercountbox.Text = u.getMemberCount(userid).ToString();
                
                
                district_no.Select();
           // }
           // else
            //{
             //   MessageBox.Show("Invalid Username or Password");
              //  passwordbox.Clear();
           // }

            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void district_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void thanabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Union u = new Union();
            Thana t = new Thana();
            District d = new District ();
            
            try
            {
                
                thana_no.Text = t.getThanaNo(thanabox.Text.ToString(), d.getDistrictNo(districtbox.Text)).ToString();
                String thanaid = "D" + district_no.Text + "T" + thana_no.Text + "";
                unionbox.DataSource = u.getUnionList(thanaid);
                unionbox.Select();
            }
            catch (Exception ex) { }

        }

        private void thana_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void districtbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thana t = new Thana();
            District d = new District();
            try
            {
                thanabox.DataSource = t.getThanaList(d.getDistrictNo(districtbox.Text.ToString()));
                district_no.Text = d.getDistrictNo(districtbox.Text.ToString()).ToString();
                thanabox.Select();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void village_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void house_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void district_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void firstline_Enter(object sender, EventArgs e)
        {

        }

        private void secondline_Enter(object sender, EventArgs e)
        {

        }

        private void chala_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void thana_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void union_Click(object sender, EventArgs e)
        {

        }

        private void chalabox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void floorbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void watersourcebox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void village_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void daylabourerbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cncbox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void relationbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void memberinfobox_Enter(object sender, EventArgs e)
        {
            
        }

        private void districtbox_Click(object sender, EventArgs e)
        {
            
        }

        private void thanabox_Click(object sender, EventArgs e)
        {
            
        }

        private void district_no_Enter(object sender, EventArgs e)
        {
           
        }

        private void district_no_Leave(object sender, EventArgs e)
        {
           
        }

        private void unionbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Union u = new Union();
            String thanaid = "D" + district_no.Text + "T" + thana_no.Text + "";
            //Village v = new Village ();
            try
            {
                union_no.Text = u.getUnionNo(unionbox.Text, thanaid).ToString();
                cncbox.Select();
                
            }
            catch (Exception ex) { }
        }

        private void userbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                passwordbox.Select();
            }
        }

        private void passwordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                login_Click(sender,e);    
            }
        }

        private void district_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    District d = new District();
                    Thana t = new Thana();
                    districtbox.Text = d.getDistrictName(Convert.ToInt32(district_no.Text));
                    thanabox.DataSource = t.getThanaList(d.getDistrictNo(districtbox.Text.ToString()));
                    thana_no.Select();
                    
                    
                }
                catch (Exception ex) {MessageBox.Show(ex.ToString()); }
            }
        }

        private void thana_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Thana t = new Thana();
                    thanabox.Text = t.getThanaName(t.generateThanaID(Convert.ToInt32(district_no.Text), Convert.ToInt32(thana_no.Text)));
                    Union u = new Union();
                    unionbox.DataSource = u.getUnionList(t.generateThanaID(Convert.ToInt32(district_no.Text), Convert.ToInt32(thana_no.Text)));
                    union_no.Select();
                    
                }
                catch (Exception ex) {MessageBox.Show(ex.ToString()); }
               
            }
        }

        private void union_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Union u = new Union();
                    unionbox.Text = u.getUnionName(u.generateUnionID( Convert.ToInt32(district_no.Text), Convert.ToInt32(thana_no.Text),Convert.ToInt32(union_no.Text)));
                    cncbox.Select();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }

        }

        private void village_no_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cncbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                khanabox.Select();
            }
        }

        private void khanabox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                membernobox.Select();
            }
        }

        private void membernobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                mothernobox.Select();
            }
        }

        private void mothernobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                membernamebox.Select();
            }
        }

        private void membernamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                relationbox.Select();
            }
        }

        private void relationbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                agebox.Select();
            }
        }

        private void agebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dobbox.Select();
            }
        }

        private void dobbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dobbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //SendKeys.Send("{TAB}");
                mobbox.Select();
            }
        }
        private void mobbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                yobbox.Select();
            }
        }

        private void yobbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                sexbox.Select();
            }
        }


        private void sexbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                maritalstatusbox.Select();
            }
        }

        private void maritalstatusbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                maritalyearbox.Select();
            }
        }

        private void maritalyearbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                educationbox.Select();
            }
        }

        private void educationbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                occupationbox.Select();
            }
        }

        private void occupationbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                weightbox.Select();
            }
        }

        private void weightbox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
             if (e.KeyChar == 13)
             {
                 heightbox.Select();
             }
            
        }

        private void heightbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                paritybox.Select();
            }
        }

        private void paritybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                membernobox.Select();
                try
                {
                    dataGridView1.Rows.Add();                    
                    dataGridView1[0, i].Value = membernobox.Text;
                    dataGridView1[1, i].Value = mothernobox.Text;
                    dataGridView1[2, i].Value = membernamebox.Text;
                    dataGridView1[3, i].Value = relationbox.Text;
                    dataGridView1[4, i].Value = agebox.Text;
                    dataGridView1[5, i].Value = dobbox.Text+"/"+mobbox.Text+"/"+yobbox.Text;
                    dataGridView1[6, i].Value = sexbox.Text;
                    dataGridView1[7, i].Value = maritalstatusbox.Text;
                    dataGridView1[8, i].Value = maritalyearbox.Text;
                    dataGridView1[9, i].Value = educationbox.Text;
                    dataGridView1[10, i].Value = occupationbox.Text;
                    dataGridView1[11, i].Value = weightbox.Text;
                    dataGridView1[12, i].Value = heightbox.Text;
                    dataGridView1[13, i].Value = paritybox.Text;

                    i++;

                    mothernobox.Clear();
                    membernamebox.Clear();
                    relationbox.Clear();
                    agebox.Clear();
                    dobbox.Clear();
                    mobbox.Clear();
                    yobbox.Clear();
                    sexbox.Clear();
                    maritalstatusbox.Clear();
                    maritalyearbox.Clear();
                    educationbox.Clear();
                    occupationbox.Clear();
                    weightbox.Clear();
                    heightbox.Clear();
                    paritybox.Clear();
                    membernobox.Clear();

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            
        }

        private void chalabox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                wallbox.Select();
            }
        }

        private void wallbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                floorbox.Select();
            }
        }

        private void floorbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                housevaluebox.Select();
            }
        }

        private void housevaluebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                totallandbox.Select();
            }
        }

        private void totallandbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                landvaluebox.Select();
            }
        }

        private void landvaluebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cowbox.Select();
            }
        }

        private void cowbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                goatbox.Select();
            }
        }

        private void goatbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                henbox.Select();
            }
        }

        private void henbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                treebox.Select();
            }
        }

        private void treebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                vegitablebox.Select();
            }
        }

        private void vegitablebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                monthscoveredbox.Select();
            }
        }

        private void monthscoveredbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bedbox.Select();
            }
        }

        private void bedbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                chairbox.Select();
            }
        }

        private void chairbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                radiobox.Select();
            }
        }

        private void radiobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tvbox.Select();
            }
        }

        private void tvbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tubewellbox.Select();
            }
        }

        private void tubewellbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                gavibox.Select();   
            }
        }

        private void gavibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                sagolbox.Select();
            }
        }

        private void sagolbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                daylabourerbox.Select();
            }
        }

        private void daylabourerbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dayslabourbox.Select();
            }
        }

        private void dayslabourbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                watersourcebox.Select();
            }
        }

        private void watersourcebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                latrinebox.Select();
            }
        }

        private void latrinebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                evaluationbox.Select();
            }
        }

        private void evaluationbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void paritybox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mothernobox_TextChanged(object sender, EventArgs e)
        {

        }

        private void membernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member();
                User u = new User();
                String cncid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "";
                String khanaid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "K" + khanabox.Text + "";
                //MessageBox.Show(khanaid);
                Khana k = new Khana();
                k.Insert(
                Convert.ToInt32(khanabox.Text),
                cncid,
                userid,
                Convert.ToInt32(chalabox.Text),
                Convert.ToInt32(wallbox.Text),
                Convert.ToInt32(floorbox.Text),
                Convert.ToInt32(watersourcebox.Text),
                Convert.ToInt32(evaluationbox.Text),
                Convert.ToInt32(housevaluebox.Text),
                Convert.ToInt32(totallandbox.Text),
                Convert.ToInt32(landvaluebox.Text),
                Convert.ToInt32(cowbox.Text),
                Convert.ToInt32(goatbox.Text),
                Convert.ToInt32(henbox.Text),
                Convert.ToInt32(treebox.Text),
                Convert.ToInt32(vegitablebox.Text),
                Convert.ToInt32(monthscoveredbox.Text),
                Convert.ToInt32(bedbox.Text),
                Convert.ToInt32(chairbox.Text),
                Convert.ToInt32(radiobox.Text),
                Convert.ToInt32(tvbox.Text),
                Convert.ToInt32(tubewellbox.Text),
                Convert.ToInt32(gavibox.Text),
                Convert.ToInt32(sagolbox.Text),
                Convert.ToInt32(daylabourerbox.Text),
                Convert.ToInt32(dayslabourbox.Text),
                Convert.ToInt32(latrinebox.Text),
                Convert.ToString(datacollectorbox.Text),
                Convert.ToString(cnocnpbox.Text),
                Convert.ToString(datebox.Text),
                khanaid);
                u.increaseKhanaCount(userid);
                khanacountbox.Text = u.getKhanaCount(userid).ToString();

                for (int j = 0; j < i; j++)
                {
                    String memberid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "K" + khanabox.Text + "M" + Convert.ToInt32(dataGridView1[0, j].Value) + "";

                    member.Insert(
                        memberid,
                        Convert.ToInt32(dataGridView1[0, j].Value),
                        Convert.ToInt32(dataGridView1[1, j].Value),
                        Convert.ToString(dataGridView1[2, j].Value),
                        Convert.ToInt32(dataGridView1[3, j].Value),
                        Convert.ToInt32(dataGridView1[4, j].Value),
                        Convert.ToString(dataGridView1[5, j].Value),
                        Convert.ToInt32(dataGridView1[6, j].Value),
                        Convert.ToInt32(dataGridView1[7, j].Value),
                        Convert.ToInt32(dataGridView1[8, j].Value),
                        Convert.ToInt32(dataGridView1[9, j].Value),
                        float.Parse(dataGridView1[11, j].Value.ToString()),
                        Convert.ToInt32(dataGridView1[12, j].Value),
                        Convert.ToInt32(dataGridView1[13, j].Value),
                        Convert.ToInt32(dataGridView1[10, j].Value),
                        khanaid);
                    u.increaseMemberCount(userid);
                    membercountbox.Text = u.getMemberCount(userid).ToString();

                }
                khanabox.Clear();
                chalabox.Clear();
                wallbox.Clear();
                floorbox.Clear();
                watersourcebox.Clear();
                evaluationbox.Clear();
                housevaluebox.Clear();
                totallandbox.Clear();
                landvaluebox.Clear();
                cowbox.Clear();
                goatbox.Clear();
                henbox.Clear();
                treebox.Clear();
                vegitablebox.Clear();
                monthscoveredbox.Clear();
                bedbox.Clear();
                chairbox.Clear();
                radiobox.Clear();
                tvbox.Clear();
                tubewellbox.Clear();
                gavibox.Clear();
                sagolbox.Clear();
                daylabourerbox.Clear();
                dayslabourbox.Clear();
                latrinebox.Clear();
                datacollectorbox.Clear();
                cnocnpbox.Clear();
                datebox.Clear();
                dataGridView1.Rows.Clear();
                i = 0;

            }
            catch (Exception ex) { }

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Khana k = new Khana();
                String khanaid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "K" + khanabox.Text + "";
                dataGridView1.Rows.Clear();
                String []info= k.getAll(khanaid);
                chalabox.Text = info[0];
                wallbox.Text = info[1];
                floorbox.Text = info[2];
                housevaluebox.Text = info[3];
                totallandbox.Text = info[4];
                landvaluebox.Text = info[5];
                cowbox.Text = info[6];
                goatbox.Text = info[7];
                henbox.Text = info[8];
                treebox.Text = info[9];
                vegitablebox.Text = info[10];
                monthscoveredbox.Text=info[11];
                bedbox.Text=info[12];
                chairbox.Text=info[13];



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void membercountbox_TextChanged(object sender, EventArgs e)
        {

        }


        
        

       
        
        
    }
}
