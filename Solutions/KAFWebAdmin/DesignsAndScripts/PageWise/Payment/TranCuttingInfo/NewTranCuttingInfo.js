﻿

//PN: FILE NAME: "Newtran_cuttinginfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveTranCuttingInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmCuttingInfoNew');
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

                    PayAllceID: $('#PayAllceID').val(),
                    OkpID: $('#OkpID').val(),
                    MonthID: $('#MonthID').val(),
                    Year: $('#Year').val(),
                    RankID: $('#RankID').val(),
                    ProcessDate: GetDateFromTextBox($('#ProcessDate').val())


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "TranCuttingInfo/TranCuttingInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "TranCuttingInfo/TranCuttingInfo";
                                            $('#mcTranCuttingInfoNew').html('');
                                            $('#modal-container-TranCuttingInfoNew').modal('hide');
                                            GetAllDataTranCuttingInfo();
                                        }
                                        else {
                                            $('#mcTranCuttingInfoNew').html('');
                                            $('#modal-container-TranCuttingInfoNew').modal('hide');
                                            GetAllDataTranCuttingInfo();
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
            $('#mcTranCuttingInfoNew').html('');
            $('#modal-container-TranCuttingInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



