﻿

//PN: FILE NAME: "Newhr_reppassportinfodetl.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrRepPassportInfoDetl', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_RepPassportInfoDetlEdit');
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

							 reppassportdetlid: $('#reppassportdetlid').val(),
							 reppassportid: $('#reppassportid').val(),
							 replacementdetlid: $('#replacementdetlid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 hrsvcid: $('#hrsvcid').val(),
							 newhrbasicid: $('#newhrbasicid').val(),
							 newhrsvcid: $('#newhrsvcid').val(),
							 newpassportno: $('#newpassportno').val(),
							 remarks: $('#remarks').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrRepPassportInfoDetl/HrRepPassportInfoDetlUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrRepPassportInfoDetl/HrRepPassportInfoDetl";
                                            $('#mcHrRepPassportInfoDetlEdit').html('');
                                            $('#modal-container-HrRepPassportInfoDetlEdit').modal('hide');
                                            GetAllDataHrRepPassportInfoDetl();
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
    
    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcHrRepPassportInfoDetlEdit').html('');
            $('#modal-container-HrRepPassportInfoDetlEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






