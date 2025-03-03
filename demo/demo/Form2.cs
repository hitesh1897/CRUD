using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace demo
{
    public partial class Form2 : Form
    {
        int tr = 0;
        int rp = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void btnstate()
        {
            updatebtn.Enabled = true;
            deletebtn.Enabled = true;
            insbtn.Text = "&save";

        }
        private void insbtn_Click(object sender, EventArgs e)
        {
            if (insbtn.Text == "insert")
            {

                if (txtsnm.Text != "" && txtmob.Text != "")
                {
                    string param = txtsnm.Text + "','" + txtmob.Text;
                    Class1.stud("insert", "student", param, "");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                    return;

                }

            }
            else
            {
                txtsnm.Text = txtmob.Text = string.Empty;
                btnstate();
            }
        }
        private void loaddata()
        {
            dataGridView1.DataSource = Class1.stud("select", "student", "", "");
            tr = Class1.stud("select", "student", "", "").Rows.Count - 1;


        }
        private void navigate()
        {
            if (tr >= 0)
            {
                loaddata();
                txtsnm.Text = Class1.stud("select", "student", "", "").Rows[rp][1].ToString();
                txtmob.Text = Class1.stud("select", "student", "", "").Rows[rp][2].ToString();
            }
        }

        private void firstbtn_Click(object sender, EventArgs e)
        {


            rp = 0;
            navigate();
            btnstate();
            

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {

            if (rp < tr)
            {
                rp++;
                navigate();
                btnstate();
            }
            else
            {
                insbtn.Text = "insert";
            }
           
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            if (rp > 0)
            {
                rp--;
                navigate();
                btnstate();
            }
            else
            {
                insbtn.Text = "insert";

            }
        }

        private void lastbtn_Click(object sender, EventArgs e)
        {
            if (tr > 0)
            {
                rp = tr;
                navigate();
                btnstate();

            }
            else
            {
                insbtn.Text = "insert";

            }

        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (txtsnm.Text != "" && txtmob.Text != "")
            {
                string param = "s_name= '" + txtsnm.Text + "'  ,  s_mob='" + txtmob.Text + "' ";
                Class1.stud("update", "student", param, Class1.stud("select", "student", "", "").Rows[rp][0].ToString());
                dataGridView1.DataSource = Class1.stud("select", "student", "", "");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string id = Class1.stud("select", "student", "", "").Rows[rp][0].ToString();    
            Class1.stud("delete","student","",id);
            dataGridView1.DataSource = Class1.stud("select", "student", "", "");

        }
    }
}
