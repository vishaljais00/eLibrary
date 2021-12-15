using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class adminmembermanagemnet : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        // Serach user button
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            getMemberById();
        }

        // active status button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            UpdateMemberStatusById("Active");
        }
        // pending status button
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            UpdateMemberStatusById("Pending");
        }
        // inactive status button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            UpdateMemberStatusById("InActive");
        }

        // inactive status button
        protected void deleteUser(object sender, EventArgs e)
        {
            deleteMemberByID();
        }


        //User define Function

        void getMemberById()
        {
            if (TextBox1.Text.Equals(""))
            {
                Response.Write("<script>alert('Member Id Cannot Be blank');</script>");
            }
            else if(CheckIfMemberExist() == false)
            {
                Response.Write("<script>alert('Invalid Member ID ');</script>");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * from member_master_tbl where member_id = '" + TextBox1.Text.Trim() + "'; ", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            TextBox2.Text = dr.GetValue(0).ToString(); // Full Name
                            TextBox7.Text = dr.GetValue(10).ToString(); // Account status
                            TextBox8.Text = dr.GetValue(1).ToString(); // Dob
                            TextBox3.Text = dr.GetValue(2).ToString(); // Contact no
                            TextBox4.Text = dr.GetValue(3).ToString(); // Email
                            TextBox9.Text = dr.GetValue(4).ToString(); // State
                            TextBox10.Text = dr.GetValue(5).ToString(); // City
                            TextBox11.Text = dr.GetValue(6).ToString(); // Pin Code
                            TextBox6.Text = dr.GetValue(7).ToString(); // Full address

                        }

                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Member Id');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
           
        }

        void UpdateMemberStatusById( string status)
        {
            if (TextBox1.Text.Equals(""))
            {
                Response.Write("<script>alert('Member Id Cannot Be blank');</script>");
            }
            else if (CheckIfMemberExist() == false)
            {
                Response.Write("<script>alert('Invalid Member ID ');</script>");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("UPDATE member_master_tbl SET account_status = '" + status + "' WHERE member_id = '" + TextBox1.Text.Trim() + "'; ", con);
                    Response.Write("<script>alert('Member Status Updated');</script>");

                    cmd.ExecuteNonQuery();
                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }  

        }

        void deleteMemberByID()
        {
            if (TextBox1.Text.Equals(""))
            {
                Response.Write("<script>alert('Member Id Cannot Be blank');</script>");
            }
            else if (CheckIfMemberExist() == false)
            {
                Response.Write("<script>alert('Invalid Member ID ');</script>");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from member_master_tbl WHERE member_id = '" + TextBox1.Text.Trim() + "'; ", con);
                    Response.Write("<script>alert('Member Deleted Updated');</script>");
                    cmd.ExecuteNonQuery();
                    clearForm();
                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
           

        }

        bool CheckIfMemberExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from member_master_tbl where member_id = '" + TextBox1.Text.Trim() + "'; ", con);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;

                }
                else
                {

                    return false;

                };
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void clearForm()
        {
            TextBox2.Text = ""; // Full Name
            TextBox1.Text = ""; // Full Name
            TextBox7.Text = "";  // Account status
            TextBox8.Text = ""; // Dob
            TextBox3.Text = ""; // Contact no
            TextBox4.Text = ""; // Email
            TextBox9.Text = ""; // State
            TextBox10.Text = ""; // City
            TextBox11.Text = ""; // Pin Code
            TextBox6.Text = ""; // Full address
        }
    }
}