﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Kota.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="ASPNET_FrontEnd.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </br>
	</br>
	</br>
    <h2 style="text-align: center;"><b>Search user</b></h2>
    <section class="banner-area  blog-page text-center">
        <div class="banner">
            <div class="container ">
                <div class="row fill_height">
                    <div class="col-lg-4 offset-lg-4 fill_height">
                        <div class="banner_content">
                            <form action="Search.aspx" method="post" class="contact-form" runat="server">
                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                         <input type="email" id="u_email" class="form-control" placeholder="Email Address" runat="server" required>
                                    </div>
                                </div>

                                <div class="row align-items-center justify-content-center">
                                    <asp:Button ID="btnSearch" type="submit" runat="server" Text="Search User" class="btn btn-warning py-2 px-5" OnClick="btnSearch_Click" />
                                </div>

                                <div class="mt-10">
                                    <asp:Label ID="lbl_error" runat="server" Text="" Visible="false"></asp:Label>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    </br>
	</br>
	</br>
	</br>
	</br>
	</br>
</asp:Content>
