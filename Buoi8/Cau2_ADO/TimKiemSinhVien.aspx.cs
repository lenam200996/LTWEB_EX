using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau2_ADO_TimKiemSinhVien : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand myCom;
    protected void Page_Load(object sender, EventArgs e)
    {
        String str = "Data Source=DESKTOP-U5V2563;Initial Catalog=LTW_SINHVIEN;User ID=sa;Password=123456";
        con = new SqlConnection(str);
        con.Open();
       
        
        display("",1);
    }

    public void display(String nd, int status)
    {
        if (status == 1)
        {
         
            String sql = "select MaSV, HoTen, TenKhoa from SinhVien join KhoaDaoTao on SinhVien.MaKhoa = KhoaDaoTao.MaKhoa";

            myCom = new SqlCommand(sql, con);

            SqlDataReader dr = myCom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else if (status == 2)
        {
            String sql = "select MaSV, HoTen, TenKhoa from SinhVien join KhoaDaoTao on SinhVien.MaKhoa = KhoaDaoTao.MaKhoa where MaSV = " + nd;

            myCom = new SqlCommand(sql, con);

            SqlDataReader dr = myCom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
        {
            String sql = "select MaSV, HoTen, TenKhoa from SinhVien join KhoaDaoTao on SinhVien.MaKhoa = KhoaDaoTao.MaKhoa where HoTen like '%" + nd + "%'";

            myCom = new SqlCommand(sql, con);

            SqlDataReader dr = myCom.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
       
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        String keyWord = txtnoidungtim.Text;
        if (drtimtheo.SelectedValue == "masv")
        {
            display(keyWord, 2);
        }
        else
        {
            display(keyWord, 3);
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int row = Convert.ToInt32(e.CommandArgument);

        String sql = "";
    }
}