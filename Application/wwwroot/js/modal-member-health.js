$(function () {
    var placeholderElement = $('#modal-placeholder');

    $(document).on('click', 'button[data-toggle="ajax-modal"]', function (event) {
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        });
    });

    placeholderElement.on('click', '[data-save="modal"]', function (event) {
        event.preventDefault();
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = new FormData(form.get(0));

        $.ajax({
            url: actionUrl,
            method: 'post',
            data: dataToSend,
            type: 'post',
            processData: false,
            contentType: false
        }).done(function (data) {
            var newBody = $('.modal-body', data);
            placeholderElement.find('.modal-body').replaceWith(newBody);

            var isValid = newBody.find('[name="IsValid"]').val() === 'True';
            if (isValid) {

                var tableElement = $('#healthissues');
                var tableUrl = tableElement.data('url');
                console.log(tableUrl);

                $.ajax({
                    url: tableUrl,
                    type: 'get',

                    cache: false,
                    success: function (table) {
                        console.log("succes")
                        tableElement.replaceWith(table);
                    },
                    error: function () {
                        alert("error");
                    }
                });


                placeholderElement.find('.modal').modal('hide');
            }
        });
    });

    $(document).on('click', 'button[data-toggle="HealthDelete"]', function (event) {
        event.preventDefault();
        var id = $(this).data('deleteid');
        var url = $(this).data('url');

        $.ajax({
            url: url,
            type: 'post',
            cache: false,
            data: JSON.stringify({'id': id}),
            success: function (data) {
                tableUpdate(data)
            },
            error: function () {
                alert("Do deleted");
            }
        });

    });

});


function tableUpdate(table) {

    var tableElement = $('#healthissues');
    var tableUrl = tableElement.data('url');
    $.ajax({
        url: tableUrl,
        type: 'get',
        cache: false,
        success: function (table) {
            console.log(table);

            var tableElement = $('#healthissues');
            tableElement.replaceWith(table);
        },
        error: function () {
            alert("error");
        }
    });


}
