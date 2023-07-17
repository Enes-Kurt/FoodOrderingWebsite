// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



document.addEventListener('DOMContentLoaded', function () {
    const loadLoginButton = document.querySelector('[data-bs-target="#offcanvasRight"]');
    loadLoginButton.addEventListener('click', function () {
        const dynamicContent = document.getElementById('dynamicContent');
        const xhr = new XMLHttpRequest();
        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4 && xhr.status === 200) {
                dynamicContent.innerHTML = xhr.responseText;
            }
        };
        xhr.open('GET', '/Identity/Account/Login', true);
        xhr.send();
    });
});

window.onload = function () {
    GetProductList('');
    $("#all").addClass('active');
    ShowShoppingCart('Show');
};


function GetProductList(element, category) {
    $('.filters_menu li').removeClass('active');
    $(element).addClass('active');
    $.ajax({
        url: "/Product/List/",
        type: "get",
        data: { categoryName: category },
        success: function (response) {
            $("#productList").html(response);
        }
           

    });
}

function ShowShoppingCart(action) {

    $.ajax({
        url: "/Product/FillShoppingCart/",
        type: "post",
        data: { ShowShoppingChart: action },
        success: function (response) {
            $("#shoppingcart").html(response);
        }

    });
}