let quiz = document.getElementById("quiz");
let label = document.getElementById("firstQuestion");
let btnA = document.getElementById("btnA");
let btnB = document.getElementById("btnB");
let btnC = document.getElementById("btnC");
let btnD = document.getElementById("btnD");
let userScore = document.getElementById("score");
let countCarrots = 0;
let pictures = document.getElementById("pictures");

function DisplayTime() {
  let date = new Date();
  let timer = document.getElementById("time");
  timer.innerHTML = date.toLocaleTimeString();
}

setInterval(DisplayTime, 1000);

DisplayFirstQuestion();

function DisplayFirstQuestion() {
  label.innerHTML = "Na czym świnka morska może zetrzeć zęby?";
  btnA.innerHTML = "A.Pomidor";
  btnB.innerHTML = "B.Marchewka";
  btnC.innerHTML = "C.Siano";
  btnD.innerHTML = "Ogórek zielony";
  userScore.innerHTML = "Zdobytych marchewek: " + countCarrots.toString();

  btnA.addEventListener("click", IncorrectAnswer);
  btnB.addEventListener("click", IncorrectAnswer);
  btnC.addEventListener("click", FirstAnswerCorrect);
  btnD.addEventListener("click", IncorrectAnswer);
}
function FirstAnswerCorrect() {
  countCarrots += 10;
  DisplayTheCollectedCarrots();
  DisplaySecondQuestion();
}

function DisplaySecondQuestion() {
  ResetButtonEventsAfterFirstCorrectAnswer();
  label.innerHTML = "Jak nazywa się termin oznaczający charakterystyczne podskawiwanie szczęśliwej świnki morskiej?";
  btnA.innerHTML = "A.Kwiczenie";
  btnB.innerHTML = "B.Popcorning";
  btnC.innerHTML = "C.Syczenie";
  btnD.innerHTML = "D.Gruchotanie";

  document.getElementById("btnA").addEventListener("click", IncorrectAnswer);
  // prettier-ignore
  document.getElementById("btnB").addEventListener("click", SecondAnswerCorrect);
  document.getElementById("btnC").addEventListener("click", IncorrectAnswer);
  document.getElementById("btnD").addEventListener("click", IncorrectAnswer);
}
function SecondAnswerCorrect() {
  countCarrots += 20;
  DisplayTheCollectedCarrots();
  DisplayThirdQuestion();
}
function DisplayThirdQuestion() {
  ResetButtonEventsAfterSecondCorrectAnswer();
  label.innerHTML = "Czego nie może jeść świnka morska?";
  btnA.innerHTML = "A.Cebuli";
  btnB.innerHTML = "B.Pietruszki";
  btnC.innerHTML = "C.Buraków";
  btnD.innerHTML = "D.Trawy";

  document.getElementById("btnA").addEventListener("click", ThirdAnswerCorrect);
  document.getElementById("btnB").addEventListener("click", IncorrectAnswer);
  document.getElementById("btnC").addEventListener("click", IncorrectAnswer);
  document.getElementById("btnD").addEventListener("click", IncorrectAnswer);
}

function ThirdAnswerCorrect() {
  countCarrots += 30;
  DisplayTheCollectedCarrots();
  DisplayFourthQuestion();
}
function DisplayFourthQuestion() {
  ResetButtonEventsAfterThirdCorrectAnswer();
  label.innerHTML = "Jaka jest rasa świnki wyświetlonej na ekranie?";

  let pigImage = document.createElement("img");
  pigImage.src = "../image/Peruwianka.jpg";
  pictures.appendChild(pigImage);

  btnA.innerHTML = "A.Peruwianka";
  btnB.innerHTML = "B.Skinny";
  btnC.innerHTML = "C.Długowłosa";
  btnD.innerHTML = "D.Teddy";

  document.getElementById("btnA").addEventListener("click", LastAnswerCorrect);
  document.getElementById("btnB").addEventListener("click", IncorrectAnswer);
  document.getElementById("btnC").addEventListener("click", IncorrectAnswer);
  document.getElementById("btnD").addEventListener("click", IncorrectAnswer);
  return;
}

function LastAnswerCorrect() {
  countCarrots += 40;
  quiz.innerHTML =
    "Gratulacje odpowiedziałeś poprawnie na wszystkie pytania. Otrzymujesz " +
    countCarrots.toString() +
    "/100 marchewek!";
  return;
}

function IncorrectAnswer() {
  if (countCarrots === 0) {
    quiz.innerHTML =
      "Niestety odpowiedź nie jest poprawna. Nie mniej jednak za udział w quizie otrzymujesz zapas siana na miesiąc ;-)";
    return;
  }
  if (countCarrots != 0) {
    quiz.innerHTML =
      "Dziękujemy za udział w quizie. Zdobyłeś " +
      countCarrots +
      "/100 marchewek. Gratulacje!";
    return;
  }
}
function ResetButtonEventsAfterFirstCorrectAnswer() {
  btnA.removeEventListener("click", IncorrectAnswer);
  btnB.removeEventListener("click", IncorrectAnswer);
  btnC.removeEventListener("click", FirstAnswerCorrect);
  btnD.removeEventListener("click", IncorrectAnswer);
}
function ResetButtonEventsAfterSecondCorrectAnswer() {
  btnA.removeEventListener("click", IncorrectAnswer);
  btnB.removeEventListener("click", SecondAnswerCorrect);
  btnC.removeEventListener("click", IncorrectAnswer);
  btnD.removeEventListener("click", IncorrectAnswer);
}
function ResetButtonEventsAfterThirdCorrectAnswer() {
  btnA.removeEventListener("click", ThirdAnswerCorrect);
  btnB.removeEventListener("click", IncorrectAnswer);
  btnC.removeEventListener("click", IncorrectAnswer);
  btnD.removeEventListener("click", IncorrectAnswer);
}
function DisplayTheCollectedCarrots() {
  userScore.innerHTML = "Zdobytych marchewek: " + countCarrots.toString();
}
