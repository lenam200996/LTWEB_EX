using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau2_ADO_NhapSuaXoaKhoaDaoTao : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand myCom;
    protected void Page_Load(object sender, EventArgs e)
    {
        String str = "Data Source=DESKTOP-U5V2563;Initial Catalog=LTW_SINHVIEN;User ID=sa;Password=123456";
        con = new SqlConnection(str);
        con.Open();
        display();
        
    }

    public void display()
    {
        String selectKhoa = "select * from KhoaDaoTao";
        myCom = new SqlCommand(selectKhoa, con);

        SqlDataReader rd = myCom.ExecuteReader();

        DataTable dt = new DataTable();
        dt.Load(rd);

        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String insertKhoa = "insert into KhoaDaoTao values ('"+txtTenKhoa.Text+"','"+txtSDT.Text+"')";
        myCom = new SqlCommand(insertKhoa, con);
        myCom.ExecuteNonQuery();
        display();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
            int row = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "edit")
            {
                txtMaKhoa.Text = GridView1.Rows[row].Cells[0].Text;
                txtTenKhoa.Text = GridView1.Rows[row].Cells[1].Text;
                txtSDT.Text = GridView1.Rows[row].Cells[2].Text;
            }
            else
            {
                String deletesql = "delete from KhoaDaoTao where MaKhoa = "+GridView1.Rows[row].Cells[0].Text;
                myCom = new SqlCommand(deletesql, con);
                myCom.ExecuteNonQuery();
                display();
            }
        
        
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        e.Cancel = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String sqlEdit = "update KhoaDaoTao set TenKhoa = '"+txtTenKhoa.Text+"' , Phone = '"+txtSDT.Text+"' where MaKhoa = "+txtMaKhoa.Text;

        myCom = new SqlCommand(sqlEdit, con);

        myCom.ExecuteNonQuery();
        display();
    }
}