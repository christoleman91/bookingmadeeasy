using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;


public class HotelsCatController : ApiController
{
    HttpRequest request = HttpContext.Current.Request;
    bme_dbDataContext db = new bme_dbDataContext();

    public Response GetCategories()
    {
        Array list = db.sp_HotelCategories_ViewAll().ToArray();
        return new Response(list, list.Length);
    }

   
}