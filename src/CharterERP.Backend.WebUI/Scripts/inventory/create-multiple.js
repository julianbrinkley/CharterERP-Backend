$(document).ready(function () {

    $('#addTextField').click(function (e) {
        e.preventDefault();
        console.log("Bbutton clicked");

        $('#vinTextboxes').append("<div class='form-group'><div class='col-md-2'></div><div class='col-md-10'><input type='text' class='form-control' /></div></div>");

    });

});