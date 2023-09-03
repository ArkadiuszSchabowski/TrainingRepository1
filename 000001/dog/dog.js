let click = 0;

document.addEventListener("keyup", function(event){
    if(event.code == "Space"){
        GetContent();
    }
})

function Start() {
  window.onload = function () {
    GetContent();
  };
}
async function GetContent() {
  let urlApi = "https://dog.ceo/api/breeds/image/random";
  let response = await fetch(urlApi);
  let data = await response.json();
  GetImage(data);
}
function GetImage(data) {
  let randomImg = document.getElementById("randomImg");
  let divText = document.getElementById("text");

  let image = data.message;
  console.log(image);
  randomImg.src = image;
  click++;
  divText.innerHTML = `Pies nr: ${click}`
}
Start();