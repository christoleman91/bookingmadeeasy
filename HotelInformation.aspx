<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="HotelInformation.aspx.cs" Inherits="HotelInformation" %>

<asp:Content runat="server" ContentPlaceHolderID="body">

    <link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="app_theme/default_theme/jquery.raty.css" rel="stylesheet" />

    <style>
        .validation-failed {
            border-color: red !important;
        }
        .error-message{
            color: red;
        }
        .error-disabled{
            display: none;
        }
    </style>

    <script src="scripts/plugins/jquery.raty.js"></script>
    <div class="container">
        <div class="hotelInfo">
            <h3 id="label_heading"></h3>
            <div id="branchesCarousel" class="carousel slide" data-ride="carousel">
                <div class="carousel-inner">
                </div>
                <a class="carousel-control-prev" href="#branchesCarousel" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#branchesCarousel" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
            <div class="innerHotelContent">
                <div class="HotelContent">
                    <div class="row">
                        <div class="col-lg-3">
                            <h4>At a glance</h4>
                        </div>
                        <div class="col-lg-5">
                            <div id="label_HotelDesc">
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div id="price">
                                <p>
                                    <b id="label_HotelPrice">€60 </b>per person per night
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-3">
                            <h4>Information</h4>
                        </div>
                        <div class="col-lg-9">
                            <div id="label_HotelInfo">
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-3">
                            <h4>Main Amenities</h4>
                        </div>
                        <div class="col-lg-9">
                            <div id="label_HotelAmenitiesMain">
                            </div>
                        </div>
                    </div>
                    <div class="allAmenities">
                        <div class="row">
                            <div class="col-lg-3">
                                <h4>All Amenities</h4>
                            </div>
                            <div class="col-lg-5">
                                <label>
                                    <b>Hotel facilities</b>
                                </label>
                                <div id="label_HotelFacilities">
                                </div>
                            </div>
                            <div class="col-lg-4">
                                <label>
                                    <b>Room facilities</b>
                                </label>
                                <div id="label_RoomFacilities">
                                </div>
                                 <label>
                                    <b>Spa facilities</b>
                                </label>
                                <div id="label_SpaFacilities">
                                </div>
                                 <label>
                                    <b>Accessibility facilities</b>
                                </label>
                                <div id="label_AccessibilityFacilities">
                                </div>
                                  <label>
                                    <b>Children facilities</b>
                                  </label>
                                <div id="label_ChildrenFacilities">
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-lg-3">
                            <h4 class="labelHotelPage">Reviews</h4>
                        </div>
                        <div class="col-lg-9" id="reviews_list">
                            
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-lg-3">
                            <h4 class="labelHotelPage">Add Review</h4>
                        </div>
                        <div class="col-lg-9">
                            <div class="form-group">
                                <label>Name</label>
                                <input type="text" id="txt_Name" maxlength="150" style="width: 50%" class="form-control" name="name" value="" />
                                <span class="error-message error-disabled">Name must be atleast 2 characters</span>
                            </div>
                            <div class="form-group">
                                <label>Rating (out of 10)</label>
                                <input type="text" id="txt_Rating" maxlength="2" style="width:50px" class="form-control" />
                                <span class="error-message error-disabled">Rating must be a number and between 0 - 10</span>
                            </div>
                            <div class="form-group">
                                <label>Title</label>
                                <input type="text" id="txt_Title" maxlength="150" style="width: 50%" class="form-control" name="name" value="" />
                                <span class="error-message error-disabled">Title must have at least 3 characters</span>
                            </div>
                            <div class="form-group">
                                <label>Comment</label>
                                <textarea class="form-control" maxlength="2000" id="txt_Comment"></textarea>
                                <span class="error-message error-disabled">Comment must have at least 10 characters</span>
                            </div>
                            <div>
                                <div onclick="saveReview()" class="btn btn-primary">Submit</div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <script src="<%= ResolveClientUrl("~/scripts/HotelInfo.js") %>" type="text/javascript"></script>

    <%-- handle bars, selected by the id below in the script --%>
    <script id="entry-template" type="text/x-handlebars-template">
        <%-- for each row/item/dataitem that is passed into the handlebars js script append the relevant column names to the {{}} location --%>
        {{#each this}}
                <div class="carousel-item">
                    <img class="d-block w-100" src="{{ImageLink}}" alt="First slide" width="500px" height="450">
                </div>
        {{/each}}
       
    </script>

    <script id="reviews-template" type="text/x-handlebars-template">
        {{#each this}}
            <div class="row">
                <div class="col-lg-3">
                    <label id="ratingGood">{{ ReviewerRating }}/10</label>
                    <br />
                    <label>{{ ReviewerName }}</label>
                    <br />
                    <label>{{ ReviewerDate }}</label>
                </div>
                <div class="col-lg-9">
                    <p>
                        <b>
                            <i>{{ ReviewerTitle }}</i>
                        </b>
                    </p>
                    <p>
                        {{ ReviewerComment }}
                    </p>
                </div>
            </div>
        {{/each}}
    </script>
</asp:Content>
