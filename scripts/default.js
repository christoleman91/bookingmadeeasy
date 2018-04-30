//$(document).ready(function () {
//    $.getJSON("api/Hotels", function (data) {

//        var count = data.Count;
//        var info = data.Data;
            
        
//        console.log(count, info);
//        x(info);
//    })


//})

//function x(data) {
//    $.each(data, function (i, item) {
//        var string = ' <div class="card-outer">' +
//            '<div class="card-img"> ' +
//            '<img src="images/apartmentRoom.jpg" alt="" /> ' +
//            '</div > ' +
//            '<div class="card-desc"> ' +
//            item.HotelDesc +
//            '</div > ' +

//            '<div class="card-price">' +
//            item.HotelPrice +
//            '</div >' +

//            ' </div > '

//        var string2 = ' <div class="card" style="width: 20rem; height: 27rem;"> <img class="card-img-top" src="./images/maldron.jpeg" alt="cheap hotel card" height="220px"> <div class="card-body"> <h5 class="card-title">' 
//            + item.HotelDesc + '</h5 > <p class="card-text"></p> </div > <a href="cheapHotelSelection.html" class="btn btn-primary"></a> </div > '

//        $("#list_hotels .row").append(string2);

//        console.log(i);
//        console.log(item);

//    })
//}

$(document).ready(function () {
    
    $.getJSON("api/HotelsCat", function (data) {

        var source = document.getElementById("entry-template").innerHTML;
        var template = Handlebars.compile(source);
        var count = data.count;
        var info = data.Data;

        console.log(info);

        var html = template(info);
        $("#hotels .row").append(html);
        template(info);
        console.log(data);
       
    })

})

function goToCatHotels(id) {
    window.location = "HotelSelection.aspx?HotelCatID=" + id


}