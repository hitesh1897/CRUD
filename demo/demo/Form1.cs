using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.DirectoryServices;
namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string param = "username='"+txtunm.Text+"' and password='"+txtpwd.Text+"'";
            string sql = Class1.Crud("mytb",param);
            if(sql=="1")
            {
                MessageBox.Show("login successfully");
            }
            else
            {
                MessageBox.Show("login Failed");

            }

        }
    }
}
