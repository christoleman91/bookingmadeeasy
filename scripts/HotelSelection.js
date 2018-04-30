$(document).ready(function () {
    
    var id = getParameterByName("HotelCatID");
    $.getJSON("api/Hotels?HotelCatID=" + id, function (data) {

        var source = document.getElementById("entry-template").innerHTML;
        var template = Handlebars.compile(source);
        var info = data.Data;


        var html = template(info);
        $("#hotels .row").html(html);
    })
    
})

function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

function goToHotel(id) {

    window.location = "HotelInformation.aspx?HotelID=" + id
}

Handlebars.registerHelper('encodeMyString', function (inputData) {
    return new Handlebars.SafeString(inputData);
});