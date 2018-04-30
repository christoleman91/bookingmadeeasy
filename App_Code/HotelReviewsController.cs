using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;

public class HotelReviewsController : ApiController // DONT FORGET API CONTROLLER 
{
    // request is the data returned by ajax call, the data keyword in the ajax
    HttpRequest request = HttpContext.Current.Request;
    // calls db
    bme_dbDataContext db = new bme_dbDataContext();

    // returns all reviews for that one hotel
    public Response GetReviews(int HotelID)
    {
        Array list = db.sp_HotelReviews_ViewAllByID(HotelID).ToArray();
        return new Response(list, list.Length);
    }

    // Insert record
    public void PutReview(int HotelID)
    {
        // select sproc from db, pass first parameter that is in the function (int hotelid) and then use the request keyword
        // to retrieve the input values or any other values that are needed
        db.sp_HotelReviews_Insert(
                HotelID,
                // request [""] <---- MUST BE THE SAME NAME AS IN THE AJAX CALL
                request["ReviewerTitle"],
                request["ReviewerName"],
                request["ReviewerComment"],
                Convert.ToInt32(request["ReviewerRating"]) // <--- IF IT IS A INT IN DATABASE OR DATETIME BE SURE THE CONVERT TO THE CORRECT FORMAT
            );
    }

}