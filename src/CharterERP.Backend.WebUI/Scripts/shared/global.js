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
        $('#overlay').css("display", "none");
    });
});