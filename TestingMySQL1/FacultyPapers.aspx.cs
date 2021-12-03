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
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = ResearchPaper3; password = pattern1");
            con.Open();
            //query to display all faculty papers
            MySqlCommand cmd = new MySqlCommand("select a_ID, a_name, pub_title, p_type, p_year, dept_name, " +
                "center_name, j_name from faculty as f natural join publication as p, author as " +
                "a natural join a_wrote as aw, published_in as pi where f.ID = a.a_ID and a.a_ID = " +
                "aw.a_ID and aw.title = p.title and p.title = pi.pub_title; ", con);
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
            findFacultyPapers();
        }
        public void insertFacultyPaper()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; " +
                "database = ResearchPaper; password = pattern1");
            conn.Open();
            //query to insert into faculty 
            MySqlCommand insertF = new MySqlCommand("insert into faculty values(@ID, @f_name, @dept_name)", conn);
            insertF.Parameters.Add("ID", MySqlDbType.VarChar, 6).Value = this.f_id.Text;
            insertF.Parameters.Add("f_name", MySqlDbType.VarChar, 20).Value = this.f_name.Text;
            insertF.Parameters.Add("dept_name", MySqlDbType.VarChar, 100).Value = this.dept_name.Text;


            MySqlCommand insertP = new MySqlCommand("insert into publication values(@title, @p_type, @p_year,@dept_name,@center_name)", conn);
            insertP.Parameters.Add("title", MySqlDbType.VarChar, 200).Value = this.title.Text;
            insertP.Parameters.Add("p_type", MySqlDbType.VarChar, 30).Value = this.type.Text;
            insertP.Parameters.Add("p_year", MySqlDbType.VarChar, 4).Value = this.p_year.Text;
            insertP.Parameters.Add("dept_name", MySqlDbType.VarChar, 100).Value = this.dept_name.Text;
            insertP.Parameters.Add("center_name", MySqlDbType.VarChar, 100).Value = this.center_name.Text;
            MySqlCommand insertJ = new MySqlCommand("insert into journal values(@j_name,@volume,@number,@j_year)", conn);
            insertJ.Parameters.Add("j_name", MySqlDbType.VarChar, 50).Value = this.j_name.Text;
            insertJ.Parameters.Add("volume", MySqlDbType.VarChar, 20).Value = this.volume.Text;
            insertJ.Parameters.Add("number", MySqlDbType.VarChar, 20).Value = this.number.Text;
            insertJ.Parameters.Add("j_year", MySqlDbType.VarChar, 4).Value = this.p_year.Text;
            conn.Close();
        }
    }
}