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
        
        public String userid = null;
        public MainForm()
        {


            InitializeComponent();
                        
        }

        

        

        private void MainForm_Load(object sender, EventArgs e)
        {

            District d = new District();
            districtbox.Items.Clear();
            districtbox.DataSource = d.getDistrictList();
            districtbox.SelectedIndex=-1;
            userbox.Select();
      
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
            //membercountbox.Visible = false;
            //membercountlabel.Visible = false;
            //khanacounlabel.Visible = false;
            //khanacountbox.Visible = false;
            userbox.Clear();
            passwordbox.Clear();
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
            cncbox.Clear();
            //districtbox.Text=null;
            dataGridView1.Rows.Clear();
            userbox.Select();
            districtbox.SelectedIndex = -1;
            thanabox.SelectedIndex = -1;
            unionbox.SelectedIndex = -1;
            unionbox.SelectedIndex = -1;
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            User u = new User();
            userid = userbox.Text;
            if (u.getPassword(userbox.Text.ToString()) == passwordbox.Text.ToString())
            {
                userbox.Visible = false;
                username.Visible = false;
                passwordbox.Visible = false;
                password.Visible = false;
                login.Visible = false;
                logout.Visible = true;
                tabControl1.Visible = true;
                //membercountbox.Visible = true;
                //membercountlabel.Visible = true;
                //khanacounlabel.Visible = true;
                //khanacountbox.Visible = true;
                //khanacountbox.Text = u.getKhanaCount(userid).ToString();
                //membercountbox.Text = u.getMemberCount(userid).ToString();
                
                
                district_no.Select();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                passwordbox.Clear();
            }

            
        }



        private void thanabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Union u = new Union();
            Thana t = new Thana();
            District d = new District ();
            
            try
            {

                thana_no.Text = t.getThanaNo(thanabox.Text.ToString(), Convert.ToInt32(district_no.Text.ToString())).ToString();
                String thanaid = "D" + district_no.Text + "T" + thana_no.Text + "";
                unionbox.DataSource = u.getUnionList(thanaid);
                unionbox.SelectedIndex = -1;
                unionbox.Select();
            }
            catch (Exception ex) { }

        }

        private void districtbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            thanabox.Text = null;
            Thana t = new Thana();
            District d = new District();
            try
            {
                district_no.Text = d.getDistrictNo(districtbox.Text.ToString()).ToString();
                thanabox.DataSource = t.getThanaList(Convert.ToInt32(district_no.Text.ToString()));
                thanabox.SelectedIndex = -1;
                thanabox.Select();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
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
                relationbox.Select();
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
                    int i = dataGridView1.RowCount-2;
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

                   // i++;

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
            if (e.KeyChar == 13)
            {
                //evaluationbox.Select();
                save_Click(sender,e);
            }
        }


        private void save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to insert?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                saveAll(sender, e);
                
            }
 
            

        }
        private void saveAll(object sender, EventArgs e)
        {

            try
            {
                Member member = new Member();
                User u = new User();
                String unionid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text +"";
                String cncid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "";
                String khanaid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "K" + khanabox.Text + "";
                //MessageBox.Show(khanaid);
                Khana k = new Khana();
                Cnc c = new Cnc ();
                
                bool cncexists = c.exist(cncid);
                if (cncexists == false)
                {
                    cncexists = c.insert(Convert.ToInt32(cncbox.Text),cncid,unionid);
                }
                if (cncexists)
                {
                    bool inserted = k.Insert(
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
                    if (inserted)
                    {
                        //u.increaseKhanaCount(userid);
                        //khanacountbox.Text = u.getKhanaCount(userid).ToString();
                        int i = dataGridView1.RowCount - 1;
                        // MessageBox.Show(i.ToString());
                        for (int j = 0; j < i; j++)
                        {
                            int mother = 0;
                            float age = 0;
                            int day = 0, month = 0, year = 0;
                            float weights = 0;
                            int heights = 0;
                            int paritys = 0;
                            int maritalyear=88;
                            String memberid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "K" + khanabox.Text + "M" + Convert.ToInt32(dataGridView1[0, j].Value) + "";
                            if (dataGridView1[4, j].Value.ToString().Length > 0)
                            {
                                age = float.Parse(dataGridView1[4, j].Value.ToString());
                            }
                            String dob = Convert.ToString(dataGridView1[5, j].Value);                            
                            String[] dobs = dob.Split('/');
                            if (dobs[0].Length > 0)
                            {
                                day = Convert.ToInt32(dobs[0]);
                            }
                            if (dobs[1].Length > 0)
                            {
                                month = Convert.ToInt32(dobs[1]);
                            }
                            if (dobs[2].Length > 0)
                            {
                                year = Convert.ToInt32(dobs[2]);
                            }
                            if (dataGridView1[8, j].Value.ToString().Length > 0)
                            {
                                maritalyear= Convert.ToInt32(dataGridView1[8, j].Value);
                            }
                            if (dataGridView1[11, j].Value.ToString().Length > 0)
                            {
                                weights = float.Parse(dataGridView1[11, j].Value.ToString());
                            }
                            if (dataGridView1[12, j].Value.ToString().Length > 0)
                            {
                                heights = Convert.ToInt32(dataGridView1[12, j].Value);
                            }
                            if (dataGridView1[13, j].Value.ToString().Length > 0)
                            {
                                paritys = int.Parse( (dataGridView1[13, j].Value.ToString()));
                            }
                            if (dataGridView1[1, j].Value.ToString().Length > 0)
                            {
                                mother=Convert.ToInt32(dataGridView1[1, j].Value);
                            }
                            if (dobs[2].Length == 4)
                            {
                                if (Math.Abs(24121 - (year * 12 + month)) <= 24)
                                    age = age / 12;
                            }
                            if (dobs[2].Length == 2)
                            {
                                if (Math.Abs(121 - (year * 12 + month)) <= 24)
                                    age = age / 12;
                            }
                            if (dobs[2].Length == 1)
                            {
                                if (Math.Abs(121 - (year * 12 + month)) <= 24)
                                    age = age / 12;
                            }
                            
                            bool Memberinserted = member.Insert(
                                memberid,
                                Convert.ToInt32(dataGridView1[0, j].Value),
                                mother,
                                Convert.ToString(dataGridView1[2, j].Value),
                                Convert.ToInt32(dataGridView1[3, j].Value),
                                age,
                                Convert.ToString(dataGridView1[5, j].Value),
                                Convert.ToInt32(dataGridView1[6, j].Value),
                                Convert.ToInt32(dataGridView1[7, j].Value),
                                maritalyear,
                                Convert.ToInt32(dataGridView1[9, j].Value),
                                weights/10,
                                heights,
                                paritys,
                                Convert.ToInt32(dataGridView1[10, j].Value),
                                khanaid);
                            if (!Memberinserted)
                            {
                                //u.increaseMemberCount(userid);

                            }
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
                        //membercountbox.Text = u.getMemberCount(userid).ToString();
                        dataGridView1.Rows.Clear();
                        khanabox.Select();
                        i = 0;
                    }
                }
                else
                {
                    
                    k.delete(khanaid);
                    member.delete(khanaid);
                    MessageBox.Show("Please check your inputs again");
                }

            }
            catch (Exception ex) {
                editbutton_Click(sender, e);                
                MessageBox.Show("Sorry all data you enter is not saved. \nThe data may not contain all required field . \nPlease re entry not saved information again and click DONE button.");
                
            }
 
        }
        private void editbutton_Click(object sender, EventArgs e)
        {

            try
            {
                Khana k = new Khana();
                Member m = new Member();
                //User u = new User();
                String khanaid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "K" + khanabox.Text + "";
               // if (k.getUserId(khanaid) == userbox.Text)
                //{
                    save.Visible = false;
                    dataGridView1.Rows.Clear();
                    String[] info = k.getAll(khanaid);
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
                    monthscoveredbox.Text = info[11];
                    bedbox.Text = info[12];
                    chairbox.Text = info[13];
                    radiobox.Text = info[14];
                    tvbox.Text = info[15];
                    tubewellbox.Text = info[16];
                    gavibox.Text = info[17];
                    sagolbox.Text = info[18];
                    daylabourerbox.Text = info[19];
                    dayslabourbox.Text = info[20];
                    watersourcebox.Text = info[21];
                    latrinebox.Text = info[22];
                    evaluationbox.Text = info[23];
                    datacollectorbox.Text = info[24];
                    cnocnpbox.Text = info[25];
                    datebox.Text = info[26];
                    String[,] meminfo = m.getAll(khanaid);
                    //MessageBox.Show(meminfo.Length.ToString());
                    int i = 0;
                    int j = 0;
                    while (meminfo[i, 0] != null)
                    {
                        dataGridView1.Rows.Add();
                        while (j < 14)
                        {
                            dataGridView1[j, i].Value = meminfo[i, j];
                            j++;
                        }
                        j = 0;
                        i++;
                    }
                    done.Visible = true;


                //}
                //else { MessageBox.Show("Sorry you are not entered this information"); }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }


        private void done_Click(object sender, EventArgs e)
        {
            String khanaid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "K" + khanabox.Text + "";
            try
            {
                Member m = new Member();
                Khana k = new Khana();
                DialogResult dr = MessageBox.Show("Are you sure to change information?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bool deleted = m.delete(khanaid);
                    if (deleted)
                    {
                        bool d = k.delete(khanaid);
                        if (d)
                        {
                            saveAll(sender, e);
                            save.Visible = true;
                            done.Visible = false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
 
            }

        }

        private void districtbox_DropDown(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Khana k = new Khana();
                Member m = new Member();
                //User u = new User();
                String khanaid = "D" + district_no.Text + "T" + thana_no.Text + "U" + union_no.Text + "C" + cncbox.Text + "K" + khanabox.Text + "";
                if (k.getUserId(khanaid) == userbox.Text)
                {
                    save.Visible = false;
                    dataGridView1.Rows.Clear();
                    String[] info = k.getAll(khanaid);
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
                    monthscoveredbox.Text = info[11];
                    bedbox.Text = info[12];
                    chairbox.Text = info[13];
                    radiobox.Text = info[14];
                    tvbox.Text = info[15];
                    tubewellbox.Text = info[16];
                    gavibox.Text = info[17];
                    sagolbox.Text = info[18];
                    daylabourerbox.Text = info[19];
                    dayslabourbox.Text = info[20];
                    watersourcebox.Text = info[21];
                    latrinebox.Text = info[22];
                    evaluationbox.Text = info[23];
                    datacollectorbox.Text = info[24];
                    cnocnpbox.Text = info[25];
                    datebox.Text = info[26];
                    String[,] meminfo = m.getAll(khanaid);
                    //MessageBox.Show(meminfo.Length.ToString());
                    int i = 0;
                    int j = 0;
                    while (meminfo[i, 0] != null)
                    {
                        dataGridView1.Rows.Add();
                        while (j < 14)
                        {

                            dataGridView1[j, i].Value = meminfo[i, j];
                            j++;
                        }
                        j = 0;
                        i++;
                    }
                    done.Visible = true;


                }
                else { MessageBox.Show("Sorry you are not entered this information"); }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to insert?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                saveAll(sender, e);

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout_Click(sender,e);
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            
            ab.Show();
        }

        
        

       
        
        
    }
}
