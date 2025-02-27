﻿

//PN: FILE NAME: "Newhr_extensioninfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrExtensionInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_ExtensionInfoEdit');
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

							 hrextensionid: $('#hrextensionid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 repatriationdate: GetDateFromTextBox($('#repatriationdate').val()),
							 extensiontill: GetDateFromTextBox($('#extensiontill').val()),
							 letterdate: GetDateFromTextBox($('#letterdate').val()),
							 letterno: $('#letterno').val(),
							 letternofilepath: $('#letternofilepath').val(),
							 letternofilename: $('#letternofilename').val(),
							 letternofiletype: $('#letternofiletype').val(),
							 letternofileextension: $('#letternofileextension').val(),
							 remarks: $('#remarks').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrExtensionInfo/HrExtensionInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrExtensionInfo/HrExtensionInfo";
                                            $('#mcHrExtensionInfoEdit').html('');
                                            $('#modal-container-HrExtensionInfoEdit').modal('hide');
                                            GetAllDataHrExtensionInfo();
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
            $('#mcHrExtensionInfoEdit').html('');
            $('#modal-container-HrExtensionInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






