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
    public partial class Theses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            findTheses();
        }
        public void findTheses()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = ResearchPaper3; password = pattern1");
            con.Open();
            //query to display thesis papers 
            MySqlCommand cmd = new MySqlCommand("select title, p_year, dept_name, center_name, a_ID, a_name from publication natural join a_wrote natural join author where p_type = 'Thesis' and a_wrote.title = publication.title and a_wrote.a_ID = author.a_ID ", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            GridView5.DataSource = ds;
            GridView5.DataBind();
            cmd.Dispose();
            con.Close();
        }
    }
}