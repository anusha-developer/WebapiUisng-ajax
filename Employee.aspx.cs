using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebapiusingAjax
{
    public partial class Employee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=.; database=DBEmployee; integrated security=SSPI");

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                FillGridview();
            }
        }
        

        protected void btnSave_Click1(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Employee values('" + txtEmpName.Text + "','" + txtEmpEmailId.Text + "','" + txtEmpPhoneno.Text + "','" + txtEmpAddress.Text + "')", con);
            cmd.ExecuteNonQuery();
            FillGridview();
            con.Close();*/

            FillGridview();
        }
        public void FillGridview()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Employee", con);
            SqlDataAdapter sqladr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqladr.Fill(dt);
            GvEmployee.DataSource = dt;
            GvEmployee.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            FillGridview();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            FillGridview();
        }
    }
}
    
