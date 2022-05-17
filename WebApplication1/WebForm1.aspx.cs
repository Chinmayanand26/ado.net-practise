using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection obj1 = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=a;Integrated Security=True");
            SqlCommand obj2 = new SqlCommand("select * from data2", obj1);
            obj1.Open();
            GridView1.DataSource = obj2.ExecuteReader();
            GridView1.DataBind();
            obj1.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             SqlConnection obj1 = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=a;Integrated Security=True");
            SqlCommand obj2 = new SqlCommand("insert into data2 values ('" + TextBox1.Text+ " ','"+ TextBox2.Text +"')",obj1);
            obj1.Open();
            obj2.ExecuteNonQuery();
            obj1.Close();

      
        }
    }
}