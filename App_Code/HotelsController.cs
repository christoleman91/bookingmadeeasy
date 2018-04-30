using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;

public class HotelsController : ApiController
{
    HttpRequest request =  HttpContext.Current.Request;
    bme_dbDataContext db = new bme_dbDataContext();

    //view all
    public Response GetHotels(int HotelCatID)
    {
        Array list = db.sp_Hotels_ViewAll(HotelCatID).ToArray();
        return new Response(list, list.Length);
    }

    //single record
    public sp_Hotels_SingleRecordResult GetHotelSingleRecord(int HotelID)
    {
        return db.sp_Hotels_SingleRecord(HotelID).SingleOrDefault();
    }
}