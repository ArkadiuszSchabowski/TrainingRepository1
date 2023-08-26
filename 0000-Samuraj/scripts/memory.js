let gameSpace = document.getElementById("game");
let arraySquare = [];
let menu = document.getElementById("menu");

menu.addEventListener("click", function(){
    window.location.href = "004.memoryMenu.html"
    return;
})

function CreateSquare() {
  let emptySquare = document.createElement("div");

  emptySquare.style.width = "20%";
  emptySquare.style.height = "7vw";
  emptySquare.style.backgroundColor = "rgb(19, 102, 4)";
  emptySquare.style.margin = "20px 15px 20px 20px";
  emptySquare.style.display = "inline-block";

  gameSpace.appendChild(emptySquare);

  return emptySquare;
}

function CreateSixteenSquares() {
  let i = 0;
  while (i < 16) {
    let emptySquare = CreateSquare();
    arraySquare.push(emptySquare);
    i++;
  }
}

function AddImagesToSquares() {
  let images = [
    "../image/biala.jpg",
    "../image/czarna.jpg",
    "../image/ciekawska.jpg",
    "../image/kolorowa.jpg",
    "../image/krotkowlosa.jpg",
    "../image/peruwianka.jpg",
    "../image/skinny.jpg",
    "../image/szara.jpg",
    "../image/biala.jpg",
    "../image/czarna.jpg",
    "../image/ciekawska.jpg",
    "../image/kolorowa.jpg",
    "../image/krotkowlosa.jpg",
    "../image/peruwianka.jpg",
    "../image/skinny.jpg",
    "../image/szara.jpg",
  ];

  for (let i = 0; i < arraySquare.length; i++) {
    let image = document.createElement("img");
    image.src = images[i];
    arraySquare[i].appendChild(image);
  }
AssignWidthAndHeightToEachImage();
}

function AssignWidthAndHeightToEachImage() {
    for (let img of arraySquare) {
      let image = img.querySelector("img");
      if (image) {
        image.style.margin = "0";
        image.style.padding = "0";
        image.style.width = "100%";
        image.style.height = "100%";
      }
    }
  }  

CreateSixteenSquares();
AddImagesToSquares();