﻿

//PN: FILE NAME: "Newgen_servicestatus.js"


var baseurl = $('#txtBaseUrl').val();



$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   
    $('body').on('click', '#btnModalCloseDetail', function (event) {
        try {
            event.preventDefault();
            $('#mcGenServiceStatusDetail').html('');
            $('#modal-container-GenServiceStatusDetail').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});


