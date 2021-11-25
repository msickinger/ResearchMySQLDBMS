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
    public partial class FacultyPapers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            findFacultyPapers();
        }
        public void findFacultyPapers()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = ResearchPaper; password = pattern1");
            con.Open();
            //query to display all faculty papers
            MySqlCommand cmd = new MySqlCommand("select * from faculty", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            GridView3.DataSource = ds;
            GridView3.DataBind();
            cmd.Dispose();
            con.Close();
           
        }
        public void submitFacInfoEvent(object sender, EventArgs e)
        {
            insertFacultyPaper();
        }
        public void insertFacultyPaper()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = ResearchPaper; password = pattern1");
            conn.Open();
            //query to insert into faculty 
            MySqlCommand insertF = new MySqlCommand("insert into faculty values(@ID, @f_name, @dept_name)", conn);
            insertF.Parameters.Add("ID", MySqlDbType.VarChar, 6).Value = this.f_id.Text;
            insertF.Parameters.Add("f_name", MySqlDbType.VarChar, 20).Value = this.f_name.Text;
            insertF.Parameters.Add("dept_name", MySqlDbType.VarChar, 20).Value = this.dept_name.Text;

            MySqlCommand insertP = new MySqlCommand("insert into publication values(@title, @p_type, @p_year,@dept_name,@center_name)", conn);
            insertP.Parameters.Add("title", MySqlDbType.VarChar, 30).Value = this.title.Text;
            insertP.Parameters.Add("p_type", MySqlDbType.VarChar, 30).Value = this.type.Text;
            insertP.Parameters.Add("p_year", MySqlDbType.VarChar, 4).Value = this.p_year.Text;
            insertP.Parameters.Add("center_name", MySqlDbType.VarChar, 30).Value = this.center_name.Text;
            insertP.Parameters.Add("p_type", MySqlDbType.VarChar, 30).Value = this.type.Text;
            insertP.Parameters.Add("dept_name", MySqlDbType.VarChar, 20).Value = this.dept_name.Text;

            conn.Close();




        }
    }
}