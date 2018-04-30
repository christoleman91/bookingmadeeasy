<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ContentPlaceHolderID="body">


    <section id="bannerImg">
            <div class="containerBanImg">
                <img id="coverPhoto" src="./images/coverPhoto.jpg" alt="cover photo">
                <div class="bannerContent">
                    <h1>Looking for a hotel but overwhelmed by the options?</h1>
                    <p>Look no further because bookingmadeeasy is here to save the day. We offer you 3 options to chose
                        from ranging from a low price to a high price, giving you an easy time to chose which hotel you want.</p>
                </div>
            </div>
        </section>
    
    <%--<div id="list_hotels">--%>
     <div class="container">
     <section id="hotels">
            <div class="hotelSection">
                <div class="row">
                    
                </div>
            </div>


     </section>
     </div>
    <script src="<%= ResolveClientUrl("~/scripts/default.js") %>" type="text/javascript"></script>
    <script id="entry-template" type="text/x-handlebars-template">
        {{#each this}}
        <div class="col-lg-4">
            <div class="hotel-cats">
                <h2>{{HotelCatTitle}}</h2>
                <div class="card" style="width: 20rem; height: 27rem;">
                    <img class="card-img-top" src="{{HotelCatImage}}" alt="cheap hotel card" height="220px">
                    <div class="card-body">
                        <h5 class="card-title">{{HotelCatTitleSmall}}</h5>
                        <p class="card-text">{{HotelCatDesc}}</p>

                    </div>
                    <div onclick="goToCatHotels({{HotelCatID}})" class="btn btn-primary">More info</div>
                </div>
            </div>
        </div>
        {{/each}}
    </script>
</asp:Content>


