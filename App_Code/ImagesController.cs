using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;


public class ImagesController : ApiController
{
    HttpRequest request = HttpContext.Current.Request;
    bme_dbDataContext db = new bme_dbDataContext();

    public Response GetImages(int HotelID)
    {
        Array list = db.sp_HotelImages_Images(HotelID).ToArray();
        return new Response(list, list.Length);
    }
    
}