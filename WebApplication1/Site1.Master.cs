using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {

                    UserLogin.Visible = true;
                    SignUp.Visible = true;
                    Lgt.Visible = false;
                    Hellouser.Visible = false;
                    Adm_lgn.Visible = true;
                    Aut_Mgmt.Visible = false;
                    Publisher_Mgmt.Visible = false;
                    Book_Inv.Visible = false;
                    Book_Iss.Visible = false;
                    Mem_Mgmt.Visible = false;
                }
                else if(Session["role"].Equals("user"))
                {
                    UserLogin.Visible = false;
                    SignUp.Visible = false;
                    Lgt.Visible = true;
                    Hellouser.Visible = true;
                    Hellouser.Text ="Hello "+ Session["username"].ToString();
                    Adm_lgn.Visible = true;
                    Aut_Mgmt.Visible = false;
                    Publisher_Mgmt.Visible = false;
                    Book_Inv.Visible = false;
                    Book_Iss.Visible = false;
                    Mem_Mgmt.Visible = false;
                }
                else if (Session["role"].Equals("admin"))
                {
                    UserLogin.Visible = false;
                    SignUp.Visible = false;
                    Lgt.Visible = true;
                    Hellouser.Visible = true;
                    Hellouser.Text = "Hello Admin";
                    Adm_lgn.Visible = false;
                    Aut_Mgmt.Visible = true;
                    Publisher_Mgmt.Visible = true;
                    Book_Inv.Visible = true;
                    Book_Iss.Visible = true;
                    Mem_Mgmt.Visible = true;
                }
            }
            catch (Exception ex)
            {
               // Response.Write("<script>alert('"+ ex.Message+"');</script>");
            }

            
        }

        protected void Admin_login(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void Author_Management(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void Publisher_Management(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void Book_Inventory(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void Book_Issuing(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void Member_Management(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagemnet.aspx");
        }

        protected void View_Books(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void User_Login(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void Sign_Up(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void Logout(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("userlogin.aspx");
        }

        protected void Hello_user(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}