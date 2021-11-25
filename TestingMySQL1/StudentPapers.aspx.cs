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
    public partial class StudentPapers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            findStudentPapers();
        }
        public void findStudentPapers()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = ResearchPaper; password = pattern1");
            con.Open();
            //query to display all student papers
            MySqlCommand cmd = new MySqlCommand("select * from student", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            GridView2.DataSource = ds;
            GridView2.DataBind();
            cmd.Dispose();
            con.Close();
           
        }
    }
}