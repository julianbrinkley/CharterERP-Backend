


$(document).ready(function () {

    $(document).ajaxStart(function () {
        //$("#loading").show();
        console.log('ajax start');
        $('#spinner').css("visibility", "visible");
        $('#overlay').css("display", "inline");
    });


    $(document).ajaxStop(function () {
        //$("#loading").show();
        console.log('ajax stop');
        $('#spinner').css("visibility", "hidden");
    });


    //cadillac vin: 1GYFK63877R208823

    //jaguar vin: SAJWA1CB0BLV13150

    //vw vin: WVWDA7AJ8AW333673

    //on search button click make call to API
    var searchButton = $('#searchButton');

    searchButton.on("click", function () {

        //get supplied vin
        var vin = $('#VIN').val();

        if (!vin)
        {
            $('#vinError').text('Please enter a 9 digit VIN number');
        }
        else
        {
            var edmundsAPI = "https://api.edmunds.com/api/vehicle/v2/vins/" + vin + "?fmt=json&api_key=jdcvrm5qhvnn6kh7pbsa3np9";

            //var edmundsAPI = "https://api.edmunds.com/api/vehicle/v2/vins/1GYFK63877R208823?fmt=json&api_key=jdcvrm5qhvnn6kh7pbsa3np9";


            $.get(edmundsAPI)
             .success(function (r) {
                 //do something on success
                 $('#spinner').css("visibility", "hidden");
                 $('#overlay').css("display", "none");

                 //get rid of any error messages
                 $('#vinError').text('');
                 $('#vinImage').removeClass("glyphicon-search").removeClass("glyphicon-remove").addClass("glyphicon-ok").css("color", "green");

                 //Year
                 $('#Year').val(r.years[0].year);

                 //Make
                 $('#Make').val(r.make.name);

                 //Model
                 $('#Model').val(r.model.name);

                 //Style
                 $('#Style').val(r.years[0].styles[0].name);

                 //Color
                 $('#Color').val(r.colors[0].options[0].name)


             })
            .fail(function (err) {
                //do something on failure
                console.log("Failed to query Edmunds");



                //Clear all textboxes
                $('#Year').val('');
                $('#Make').val('');
                $('#Model').val('');
                $('#Style').val('');
                $('#Color').val('');



                $('#vinImage').removeClass("glyphicon-search").addClass("glyphicon-remove").css("color", "red");
                $('#vinError').text('Unable to retrieve vehicle. Please re-enter the VIN or try again.');
                $('#overlay').css("display", "none");


            })
            .done(function () {
                //do something in any case - default
                $('#spinner').css("visibility", "hidden");
                $('#overlay').css("display", "none");
            });
        }




        return false;
    })








});
