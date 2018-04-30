<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="HotelSelection.aspx.cs" Inherits="HotelSelection" %>

<asp:Content runat="server" ContentPlaceHolderID="body">

    <div class="container">
        <section id="hotels">
            <div class="hotelSection">
                <div class="row">
                </div>
            </div>


        </section>
    </div>

    <script src="<%= ResolveClientUrl("~/scripts/HotelSelection.js") %>" type="text/javascript"></script>
     <script id="entry-template" type="text/x-handlebars-template">

        {{#each this}}
        <div class="col-lg-4">
            <div class="hotel-cats">
                <h2>{{HotelName}}</h2>
                <div class="card" style="width: 20rem; height: 27rem;">
                    <img class="card-img-top" src="" alt="cheap hotel card" height="220px">
                    <div class="card-body">
                        <h5 class="card-title">{{HotelName}}</h5>
                        <p class="card-text">{{{HotelDesc}}}</p>

                    </div>
                    <div onclick="goToHotel({{HotelID}})" class="btn btn-primary">More info</div>
                </div>
            </div>
        </div>
        {{/each}}
    </script>
</asp:Content>
