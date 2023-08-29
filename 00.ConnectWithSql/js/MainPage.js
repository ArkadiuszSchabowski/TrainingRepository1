let plWord = document.getElementById("plWord");
let engWord = document.getElementById("engWord");
let btnPl = document.getElementById("btnPl");
let btnEng = document.getElementById("btnEng");
let dictionaryPl = [];
let dictionaryEng = [];
let randomNumber;
let btnOk = document.getElementById("btnOk");
let lastContent = document.getElementById("content3");
let result = document.getElementById("result");
let btnShow = document.getElementById("btnShowAllWords");

function AddWords() {
  let i = 1;

  while (i <= 100) {
    dictionaryPl[i] = i;
    dictionaryEng[i] = i;
    i++;
  }
  dictionaryPl[0] = "pies";
  dictionaryPl[1] = "kot";
  dictionaryPl[2] = "świnka morska";

  dictionaryEng[0] = "dog";
  dictionaryEng[1] = "cat";
  dictionaryEng[2] = "guinea pig";
}
AddWords();

btnPl.addEventListener("click", function () {
    randomNumber = RandomInteger(0,2);
    plWord.value = dictionaryPl[randomNumber];
    console.log(randomNumber);
});

btnEng.addEventListener("click", function () {
    randomNumber = RandomInteger(0,2);
    engWord.value = dictionaryEng[randomNumber];
    console.log(randomNumber);
});


//Losowanie liczby
function RandomInteger(min, max) {
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

function GetTime() {
  let clock = document.getElementById("clock");
  let date = new Date();
  clock.innerHTML = date.toLocaleTimeString();
}
setInterval(GetTime, 1000);

btnShow.addEventListener("click", ShowWords);

function ShowWords(){
    result.value = dictionaryPl;
}