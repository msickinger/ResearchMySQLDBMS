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
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = ResearchPaper; password = pattern1");
            con.Open();
            //query to display thesis papers 
            MySqlCommand cmd = new MySqlCommand("select * from publication", con);
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