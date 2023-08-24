let question = document.getElementById("question");
let information = document.getElementById("informationForUser");
let mushroom = document.getElementById("borowik");

question.innerHTML = "1.Jaki grzyb widnieje na zdjęciu?";

document.getElementById("buttonA").addEventListener("click", firstIncorrectAnswer);
document.getElementById("buttonB").addEventListener("click", firstIncorrectAnswer);
document.getElementById("buttonC").addEventListener("click", firstCorrectAnswer);
document.getElementById("buttonD").addEventListener("click", firstIncorrectAnswer);


function DisplaySecondQuestion(){
  question.innerHTML = "2.Który z tych grzybów jest trujący?"

};

function firstIncorrectAnswer() {
  information.innerHTML = "Niestety, grzyb na zdjęciu to borownik. Nie mniej jednak dostajesz nagrodę pocieszenia zupę borowikową";
  return;
}
function firstCorrectAnswer() {
  information.innerHTML = "To jest poprawna odpowiedź";
  DisplaySecondQuestion();
  document.getElementById("buttonA").addEventListener("click", secondCorrectAnswer);
  document.getElementById("buttonB").addEventListener("click", firstIncorrectAnswer);
  document.getElementById("buttonC").addEventListener("click", firstIncorrectAnswer);
  document.getElementById("buttonD").addEventListener("click", firstIncorrectAnswer);
  return;
}

function secondCorrectAnswer(){
  "To poprawna odpowiedź gratulacje"
}
