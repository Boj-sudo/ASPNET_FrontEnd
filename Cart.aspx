<%@ Page Title="" Language="C#" MasterPageFile="~/Kota.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ASPNET_FrontEnd.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="banner-area blog-page text-center">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="mb-3 mt-5 bread">Cart</h1>

                    <form action="#" runat="server">
                        <div class="row form-group" visible="false" runat="server" id="error">
                            <div class="col-md-12">
                                <br />
                                <textarea name="message" id="message" cols="30" rows="2" class="form-control" placeholder="" runat="server"></textarea>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>
    <br />

    <section class="ftco-section ftco-cart">
        <div class="container">
            <div class="row">
                <div class="col-md-12 ftco-animate">
                    <div class="cart-list" id="showcart" runat="server">
                    </div>

                    <div class="cart_buttons d-flex flex-row align-items-start justify-content-start">
                        <div class="cart_buttons_inner ml-sm-auto d-flex flex-row align-items-start justify-content-start flex-wrap">
                            <div><a href="clearCart.aspx" class="btn btn-warning py-3 px-4">clear cart</a></div>
                            &nbsp
                            &nbsp
                            <div><a href="Shop.aspx" class="btn btn-warning py-3 px-4">continue shopping</a></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row justify-content-end">
                <div class="col col-lg-3 col-md-6 mt-5 cart-wrap ftco-animate">
                    <div class="cart-total mb-3" id="totalcart" runat="server">
                    </div>
                    <p class="text-center"><a href="checkoutProduct.aspx" class="btn btn-warning py-3 px-4">Proceed to Checkout</a></p>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
