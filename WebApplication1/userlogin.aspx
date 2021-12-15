<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="WebApplication1.userlogin" %>
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
                                        <img width="150px" src="imgs/generaluser.png" />
                                    </center>  
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <center>
                                       <h3>Member Login</h3>
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
                                        <asp:TextBox ID="UserId" CssClass="form-control" runat="server" placeholder="Member ID"></asp:TextBox>
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
                                <asp:Button ID="login" OnClick="Login" CssClass="btn btn-success btn-block btn-lg" runat="server"  Text="Login" />
                             </div>

                            <div class="form-group">
                            <a href="usersignup.aspx">    
                                <input id="button2" Class="btn btn-info btn-block btn-lg" type="button" value="Sign up" />
                            </a>
                             </div>
                         </div>
                    </div>

                    <a href="hompage.aspx"> << Back To Home </a>
                </div>

          </div>
      </div>


</asp:Content>
