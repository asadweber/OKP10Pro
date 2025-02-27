﻿

//PN: FILE NAME: "Newhr_passportinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrPassportInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_PassportInfoEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

			 //var kaffileUploader = $('#id').kaffileUploader();
			 //var fileobjects_tbl_passportfiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_passportfiledescription');
			 //var fileobjects = fileobjects_tbl_passportfiledescription;

			 // $.each(fileobjects, function (key, valueObj) {
				//	  valueObj.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
			 //  });



            
            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 passportid: $('#passportid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 passportno: $('.passportno').val(),
							 passportissuedate: GetDateFromTextBox($('#passportissuedate').val()),
							 passportexpirydate: GetDateFromTextBox($('#passportexpirydate').val()),
							 //passportissuecountryid: $('#passportissuecountryid').val(),
							 //isfamilypassport: $('#isfamilypassport').val(),
							 //passportfiledescription: $('#passportfiledescription').val(),
							 //passportfilepath: $('#passportfilepath').val(),
							 //passportfilename: $('#passportfilename').val(),
							 //passportfiletype: $('#passportfiletype').val(),
							 //passportextension: $('#passportextension').val(),
							 //passportfileid: $('#passportfileid').val(),
							 //remarks: $('#remarks').val(),
							 //forreview: $('#forreview').val(),
							 iscurrent: $('#iscurrent').val()
							 //cor_foldercontentsList: fileobjects


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrPassportInfo/HrPassportInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           window.location.href =  baseurl + "HrPassportInfo/HrPassportInfo";
                                            $('#mcHrPassportInfoEdit').html('');
                                            $('#modal-container-HrPassportInfoEdit').modal('hide');
                                            //GetAllDataHrPassportInfo();
                                        }

                                    });

                                }

                                else {
                                    $.alert({
                                        title: _getCookieForLanguage("_informationTitle"),
                                        content: "Passport number already exists",
                                        type: 'red'
                                    });
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
            $('#mcHrPassportInfoEdit').html('');
            $('#modal-container-HrPassportInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






