using System.Data.Sql;
using System.Data;
using Microsoft.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;

namespace demo
{
    class Class1
    {

        public static  SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\demo\\demo\\bin\\Debug\\Database1.mdf;Integrated Security=True");
        public static DataTable stud(string qtype ,string tblnm,string param,string id)
        {
            
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            if(qtype  == "select")
            {
                string sql = "select * from  "+tblnm+" ";
                da = new SqlDataAdapter(sql,con);
                da.Fill(dt);
                return dt;

            }
            if (qtype == "insert")
            {
                string sql = "insert into " + tblnm + " values ('" + param + "')";
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                return dt;

            }

           if(qtype== "update")
            {
                string sql = "update " + tblnm + " set "+param+" where id ='"+id+"' ";
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                return dt;
            }
            if(qtype == "delete")
            {
                string sql = "delete "+tblnm+" where id='"+id+"' ";
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
                return dt;
        }
        public static string Crud(string tblnm , string param)
        {
            
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            
                string sql = "select  *  from  "+tblnm+" where "+param+" ";
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                return "1";
            }
            else
            {
                return "2";
            }

               
            
        }
    }
}
