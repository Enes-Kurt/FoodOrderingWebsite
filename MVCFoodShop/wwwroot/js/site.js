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