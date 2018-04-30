$(document).ready(function () {

    $("#rating").raty({starType:'i'})

    var id = getParameterByName("HotelID");

    // use labels here because there is only one hotel
    $.getJSON("api/Hotels?HotelID=" + id, function (data) {
        console.log(data)

        $("#label_heading").html(data.HotelName);
        $("#label_HotelDesc").html(data.HotelDesc);
        $("#label_HotelPrice").html(data.HotelPrice);
        $("#label_HotelInfo").html(data.HotelInfo);
        $("#label_HotelAmenitiesMain").html(data.HotelAmenitiesMain);
        $("#label_HotelFacilities").html(data.HotelFacilities);
        $("#label_RoomFacilities").html(data.HotelRoomFacilities);
        $("#label_SpaFacilities").html(data.HotelSpaFacilities);
        $("#label_AccessibilityFacilities").html(data.HotelAccessFacilities);
        $("#label_ChildrenFacilities").html(data.HotelChildrenFacilities);

    })

    // using handlebars because there are multiple images
    $.getJSON("api/Images?HotelID=" + id, function (data) {
        console.log(data)

        // Select the element script by its id
        var source = document.getElementById("entry-template").innerHTML;
        // use handlebars compile to esentially render the template in the javascript code
        var template = Handlebars.compile(source);

        // append the data from function(data) (console.log just data to see why in more detail), so append the data.Data object to info
        var info = data.Data;

        // Append the new info to the template (here the handlebars will loop through your data and create the new elements for each item in the database returned)
        var html = template(info);

        // select the outer element of the desired place for the new elements to be appended to
        $(".carousel-inner").html(html);

        // only for carousel set firs item as active
        var items = $(".carousel-item");
        $(items[0]).addClass("active");
    })

    // using handle bars because there might be more than one review
    $.getJSON("api/HotelReviews?HotelID=" + id, function (data) {

        var source = document.getElementById("reviews-template").innerHTML;
        var template = Handlebars.compile(source);
        var info = data.Data;

        var html = template(info);
        $("#reviews_list").html(html);

    })

})

function saveReview() {

    // Create isValid bool to test if any of the ifs failed
    var isValid = true;

    // Select all inputs
    var name = $("#txt_Name");
    var rating = $("#txt_Rating");
    var title = $("#txt_Title");
    var comment = $("#txt_Comment");

    // Validate inputs via if statments

    if (name.val().length < 2) {

        // if above statment fails add class
        name.addClass("validation-failed");

        // remove and then add change event that will remove the red border on the selected input
        name.off("click", removeValidation);
        name.on("change", removeValidation);

        // Select next element from the NAME and remove class error-disabled (it is disabled by default in html)
        name.next().removeClass("error-disabled");

        // set isValid to false cuz it failed the validation
        isValid = false;
    }

    if (isNaN(parseInt(rating.val()))) {

        rating.addClass("validation-failed");

        rating.off("click", removeValidation);
        rating.on("change", removeValidation);

        rating.next().removeClass("error-disabled");

        isValid = false;

    } else if (parseInt(rating.val()) > 10) {

        rating.addClass("validation-failed");

        rating.off("click", removeValidation);
        rating.on("change", removeValidation);

        rating.next().removeClass("error-disabled");

        isValid = false;

    }

    if (title.val().length < 2) {

        title.addClass("validation-failed");

        title.off("click", removeValidation);
        title.on("change", removeValidation);

        title.next().removeClass("error-disabled");

        isValid = false;
    }

    if (comment.val().length < 2) {
        comment.addClass("validation-failed");

        comment.off("click", removeValidation);
        comment.on("change", removeValidation);

        comment.next().removeClass("error-disabled");
        isValid = false;
    }

    // if is valid go to this block
    if (isValid) {
        // ajax call function
        $.ajax({
            // the api > controller > query string
            url: 'api/HotelReviews?HotelID=' + getParameterByName("HotelID"),
            // type of function it should go to in the controller (4 types all together PUT/PUSH/GET/DELETE)
            type: 'PUT',
            // Data object you are sending the the controller
            data: {
                // left side ALWAYS the same as in the controller request[""] , right side are the input values
                ReviewerName: name.val(),
                ReviewerTitle: title.val(),
                ReviewerComment: comment.val(),
                ReviewerRating: rating.val()
            },
            // if all g then do this
            success: function (data) {
                location.reload();
            },
            // if all b then do this
            error: function (e) {
                alert("uh oh something went wrong");
            }
        });

    }
}

// Removing validation event
function removeValidation(e) {
    $(e.currentTarget).removeClass("validation-failed")
    $(e.currentTarget).next().addClass("error-disabled");
}

function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

Handlebars.registerHelper('ifThird', function (index, options) {
    if (index % 3 == 0) {
        return options.fn(this);
    } else {
        return options.inverse(this);
    }

});


