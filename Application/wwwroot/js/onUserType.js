

$(document).ready(function() {


    forPlayerType();

    $('#player-type').on("change", function () {forPlayerType()});


    function forPlayerType() {



        var selected = $('#player-type').find(':selected').text();

        if (selected === "Member") {
            $("#player-position").hide();
        } else {
            $("#player-position").show();
        }
    }

});
    
   