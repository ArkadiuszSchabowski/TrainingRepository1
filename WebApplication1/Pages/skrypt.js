function changeColor(newColor)
{
 var elem = document.getElementById("para1");
 elem.style.color = newColor;
}


 
let button = document.getElemendbyID("button")
let engButton = document.getElementById("eng")
let plButton = document.getElementById("pl")
 
function eng() {
    document.documentElement.lang = "en"
    document.getElementById("login-header").innerHTML = languageElements.en.loginHeader
    document.getElementById("login-password").innerHTML = languageElements.en.loginPassword
    document.getElementById("login-submit").innerHTML = languageElements.en.loginHeader
}
 
function pl() {
    document.documentElement.lang = "pl"
    document.getElementById("login-header").innerHTML = languageElements.pl.loginHeader
    document.getElementById("login-password").innerHTML = languageElements.pl.loginPassword
    document.getElementById("login-submit").innerHTML = languageElements.pl.loginHeader
}
 
engButton.addEventListener("click", eng)
plButton.addEventListener("click", pl)