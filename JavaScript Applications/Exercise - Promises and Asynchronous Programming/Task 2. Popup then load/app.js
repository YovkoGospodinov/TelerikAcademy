'use strict';

var btn = document.getElementById("action");
btn.style.display = "inline";
var messageContainer = document.getElementById("redirect");
messageContainer.style.display = "none";

btn.addEventListener("click", changeState);

function changeState() {
    btn.style.display = "none";
    messageContainer.style.display = "inline";
}

function redirect() {
    window.location = "http://www.google.com";
}

let redirectPromise = new Promise((resolve, reject) => {
    setTimeout(() => {
        resolve();
    }, 3000);
});

redirectPromise
    .then(redirect);