using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace ResearchMySQLDBMS
{
    public partial class Authors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            findAuthors();
        }

        public void findAuthors()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = ResearchPaper3; password = pattern1");
            con.Open();
            //need query to display all authors 
            MySqlCommand cmd = new MySqlCommand("select * from author", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            GridView6.DataSource = ds;
            GridView6.DataBind();
            cmd.Dispose();
            con.Close();
        }
    }
}