﻿var counts = 0;

var oldValue = 0;

var hide = document.getElementById("hideMessage");

var messageLenght = document.getElementById("message");
var x = "" + messageLenght.innerText;

//function for alert message
if (x.length > 0) {

    this.messageLenght.style.height = '60px';
    this.messageLenght.style.paddingTop = '10px';
    $("#hideMessage").show().delay(2500).fadeOut();

    x.innerText = "";
}


//$(function () {
//    $('[data-toggle="dropdown"]').tooltip('toggle')
//})


//var dropMenu = document.getElementById('main-button-dropdown');

//var dropMenuLinks = document.getElementById('drop-menu-links-js');

//onmouseover = "showOnHover();"

//function showOnHover() {

//dropMenu.setAttribute("class", "btn-group show");

//dropMenuLinks.setAttribute("class", "dropdown-menu dropdown-menu-left show");

//}

// enviorment click to execute function
//window.onclick = function hideOnLeave() {

//    dropMenu.setAttribute("class", "btn-group");

//    dropMenuLinks.setAttribute("class", "dropdown-menu dropdown-menu-left");

//}

//(function () {
//    document.querySelector("#cookieConsent button[data-cookie-string]").addEventListener("click", function (el) {
//        document.cookie = el.target.dataset.cookieString;
//        document.querySelector("#cookieConsent").classList.add("hidden");
//    }, false);
//})();