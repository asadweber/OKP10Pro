﻿

//PN: FILE NAME: "Newgen_leavebalance.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveGenLeaveBalance', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmGen_LeaveBalanceNew');
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

							 leavebalanceid: $('#leavebalanceid').val(),
							 foryear: $('#foryear').val(),
							 fromdate: GetDateFromTextBox($('#fromdate').val()),
							 todate: GetDateFromTextBox($('#todate').val()),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenLeaveBalance/GenLeaveBalanceInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "GenLeaveBalance/GenLeaveBalance";
                                            $('#mcGenLeaveBalanceNew').html('');
                                            $('#modal-container-GenLeaveBalanceNew').modal('hide');
                                            GetAllDataGenLeaveBalance();
                                        }
                                        else
                                        {
                                            $('#mcGenLeaveBalanceNew').html('');
                                            $('#modal-container-GenLeaveBalanceNew').modal('hide');
                                            GetAllDataGenLeaveBalance();
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
            $('#mcGenLeaveBalanceNew').html('');
            $('#modal-container-GenLeaveBalanceNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



