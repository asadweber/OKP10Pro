﻿

//PN: FILE NAME: "Newgen_yearlyholiday.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateGenYearlyHoliday', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmGen_YearlyHolidayEdit');
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

							 holidayid: $('#holidayid').val(),
							 holidaydate: GetDateFromTextBox($('#holidaydate').val()),
							 holidayname: $('#holidayname').val(),
							 holidaytype: $('#holidaytype').val(),
							 holidaymonth: $('#holidaymonth').val(),
							 holidayday: $('#holidayday').val(),
							 holidayyear: $('#holidayyear').val(),
							 dayname: $('#dayname').val(),
							 monthname: $('#monthname').val(),
							 isfixedforallyear: $('#isfixedforallyear').val(),
							 isweekday: $('#isweekday').val(),
							 isbusinessday: $('#isbusinessday').val(),
							 previousbusinessday: GetDateFromTextBox($('#previousbusinessday').val()),
							 nextbusinessday: GetDateFromTextBox($('#nextbusinessday').val()),
							 isleapyear: $('#isleapyear').val(),
							 remarks: $('#remarks').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenYearlyHoliday/GenYearlyHolidayUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "GenYearlyHoliday/GenYearlyHoliday";
                                            $('#mcGenYearlyHolidayEdit').html('');
                                            $('#modal-container-GenYearlyHolidayEdit').modal('hide');
                                            GetAllDataGenYearlyHoliday();
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
            $('#mcGenYearlyHolidayEdit').html('');
            $('#modal-container-GenYearlyHolidayEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






