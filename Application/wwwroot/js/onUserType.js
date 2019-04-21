


$(document).ready(function() {

    forPlayerType();

    $('#player-type').on("change", function () {forPlayerType()});


    function forPlayerType() {



        var selected = $('#player-type').find(':selected').text();

        if (selected === "Member") {
            //Hide possiton field
            $("#player-position").hide();
            
            //Hide Doctor tab
            
        } else {
            $("#player-position").show();
        }

       
    }

    $("#memberForm").data("validator").settings.ignore = ".ignore";
    

    $("#memberSave").click(function () {

        var validator = $("form").validate();
        var isValid = $("form").valid();
        console.log("isvalid" + isValid);
       
    });


    });


    
   