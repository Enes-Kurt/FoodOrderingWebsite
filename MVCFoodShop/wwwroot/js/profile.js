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