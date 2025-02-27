﻿

//PN: FILE NAME: "Newgen_currencyexchagerate.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveGenCurrencyExchageRate', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmCurrencyExchageRateNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);




    
            if (form.valid()) {

               
                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 currencyexchagerateid: $('#currencyexchagerateid').val(),
							 fromcurrencyname: $('#fromcurrencyname').val(),
							 tocurrencyname: $('#tocurrencyname').val(),
							 rate: $('#rate').val(),
							 ratedatefrom: GetDateFromTextBox($('#ratedatefrom').val()),
							 ratedateto: GetDateFromTextBox($('#ratedateto').val()),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenCurrencyExchageRate/GenCurrencyExchageRateInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "GenCurrencyExchageRate/GenCurrencyExchageRate";
                                            $('#mcGenCurrencyExchageRateNew').html('');
                                            $('#modal-container-GenCurrencyExchageRateNew').modal('hide');
                                            GetAllDataGenCurrencyExchageRate();
                                        }
                                        else
                                        {
                                            $('#mcGenCurrencyExchageRateNew').html('');
                                            $('#modal-container-GenCurrencyExchageRateNew').modal('hide');
                                            GetAllDataGenCurrencyExchageRate();
                                        }
                                    });
                                }

                                else {
                                    return;
                                }
                            }
                        });
                    }
                });
            }
            else {
                return;
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
    
    
    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcGenCurrencyExchageRateNew').html('');
            $('#modal-container-GenCurrencyExchageRateNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



