<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="WebApplication1.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
          <div class="container mt-3">
          <div class="row">
                <div class="col-md-6 mx-auto">
                    <div class="card">
                        <div class="card-body">
                             <div class="row">
                                <div class="col">
                                    <center>
                                        <img width="150px" src="imgs/adminuser.png" />
                                    </center>  
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <center>
                                       <h3>Admin Login</h3>
                                    </center>  
                                </div>
                            </div>

                             <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>

                             <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        <asp:TextBox ID="UserId" CssClass="form-control" runat="server" placeholder="Admin ID"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                              <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        <asp:TextBox ID="password" CssClass="form-control" TextMode="Password" runat="server" placeholder="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Button  OnClick="Admin_login" CssClass="btn btn-success btn-block btn-lg" runat="server" Text="Login" />
                             </div>
                         </div>

                    </div>

                    <a href="hompage.aspx"> << Back To Home </a>
                </div>

          </div>
      </div>    

</asp:Content>
