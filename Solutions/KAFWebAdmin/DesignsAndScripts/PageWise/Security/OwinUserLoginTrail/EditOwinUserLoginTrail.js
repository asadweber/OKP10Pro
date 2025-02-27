﻿

//PN: FILE NAME: "Newowin_userlogintrail.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateOwinUserLoginTrail', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmOwin_UserLoginTrailEdit');
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

							 serialno: $('#serialno').val(),
							 userid: $('#userid').val(),
							 masteruserid: $('#masteruserid').val(),
							 loginfrom: $('#loginfrom').val(),
							 logindate: GetDateFromTextBox($('#logindate').val()),
							 logoutdate: GetDateFromTextBox($('#logoutdate').val()),
							 machineip: $('#machineip').val(),
							 loginstatus: $('#loginstatus').val(),
							 loginstatusbit: $('#loginstatusbit').val(),
							 sessionid: $('#sessionid').val(),
							 usertoken: $('#usertoken').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "OwinUserLoginTrail/OwinUserLoginTrailUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "OwinUserLoginTrail/OwinUserLoginTrail";
                                            $('#mcOwinUserLoginTrailEdit').html('');
                                            $('#modal-container-OwinUserLoginTrailEdit').modal('hide');
                                            GetAllDataOwinUserLoginTrail();
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
            $('#mcOwinUserLoginTrailEdit').html('');
            $('#modal-container-OwinUserLoginTrailEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






