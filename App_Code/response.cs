using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Resp
/// </summary>
public class Response
{
    public Array Data { get; set; }
    public int Count { get; set; }
    public string Errors { get; set; }

    public Response(Array data, int count)
    {
        Data = data;
        Count = count;
    }

    public Response(Array data) // ctor if we need data only, count doesnt matter
    {
        Data = data;
    }

    public Response(string error)
    {
        Errors = error;
    }

    public Response()
    {

    }
}