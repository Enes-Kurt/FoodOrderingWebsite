function MyProfileFunc() {
    $.ajax({
        url: "/Profile/ProfileSettings/",
        type: "get",//method: "get"//type ve method aynı işi yapar
        success: function (response) {
            $("#myProfile").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#profileSettings").html(response); //ajax la id si list olanı bul ve html ini boşalt
            $("#changePassword").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#addresses").html(""); //ajax la id si list olanı bul ve html ini boşalt


        }, //sonuc başarılı ise bunu dön

        error: function () {
            $("error").html("<h3>Error fetching profile settings information </h3>");
        }
    });//ajax kullan
}

function ProfileSettingsFunc() {
    $.ajax({
        url: "/Profile/ProfileSettings/",
        type: "get",//method: "get"//type ve method aynı işi yapar
        success: function (response) {
            $("#myProfile").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#profileSettings").html(response); //ajax la id si list olanı bul ve html ini boşalt
            $("#changePassword").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#addresses").html(""); //ajax la id si list olanı bul ve html ini boşalt


        }, //sonuc başarılı ise bunu dön

        error: function () {
            $("error").html("<h3>Error fetching profile settings information </h3>");
        }
    });//ajax kullan
}


function UpdateProfileSettings(userID) {
    let person = {
        id: userID,
        firstName:$("#updateFirstName").val(),
        lastName:$("#updateLastName").val(),
        eMail:$("#updateEmail").val(),
        phoneNumber: $("#updatePhoneNumber").val(),
    }
    $.ajax({
        url: "/Profile/ProfileSettings/",
        type: "post",//method: "get"//type ve method aynı işi yapar
        data: person,
        success: function (response) {
            $("#myProfile").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#profileSettings").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#changePassword").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#addresses").html(""); //ajax la id si list olanı bul ve html ini boşalt
            MyProfileFunc();

        }, //sonuc başarılı ise bunu dön

        error: function () {
            $("error").html("<h3>Error fetching profile settings information </h3>");
        }
    });//ajax kullan
}


function ChangePasswordFunc() {
    $.ajax({
        url: "/Profile/ChangePassword/",
        type: "get",//method: "get"//type ve method aynı işi yapar
        success: function (response) {
            $("#myProfile").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#profileSettings").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#changePassword").html(response); //ajax la id si list olanı bul ve html ini boşalt
            $("#addresses").html(""); //ajax la id si list olanı bul ve html ini boşalt

        }, //sonuc başarılı ise bunu dön

        error: function () {
            $("error").html("<h3>Error fetching change password information </h3>");
        }
    });//ajax kullan
}

function UpdateChangePassword() {
    var newPassword = $("#updateNewPassword").val();

    $.ajax({
        url: "/Profile/ChangePassword/",
        type: "post",
        data: { "newPassword": newPassword },
        success: function (response) {
            $("#myProfile").html("");
            $("#profileSettings").html("");
            $("#changePassword").html("");
            $("#addresses").html("");
            MyProfileFunc();
        },
        error: function () {
            $("#error").html("<h3>Error fetching profile settings information</h3>");
        }
    });
}

function AddressesFunc() {
    $.ajax({
        url: "/Profile/Addresses/",
        type: "get",//method: "get"//type ve method aynı işi yapar
        success: function (response) {
            $("#myProfile").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#profileSettings").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#changePassword").html(""); //ajax la id si list olanı bul ve html ini boşalt
            $("#addresses").html(response); //ajax la id si list olanı bul ve html ini boşalt


        }, //sonuc başarılı ise bunu dön

        error: function () {
            $("error").html("<h3>Error fetching addresses information </h3>");
        }
    });//ajax kullan
}