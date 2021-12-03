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
    public partial class ResearchCenters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            findCenters();
        }

        public void findCenters()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = ResearchPaper3; password = pattern1");
            con.Open();
            //query to display research centers 
            MySqlCommand cmd = new MySqlCommand("select * from res_center natural join res_dept", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            GridView4.DataSource = ds;
            GridView4.DataBind();
            cmd.Dispose();
            con.Close();
        }
    }
}