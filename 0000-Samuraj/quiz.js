let quiz = document.getElementById("quiz");
let label = document.getElementById("firstQuestion");
let btnA = document.getElementById("btnA");
let btnB = document.getElementById("btnB");
let btnC = document.getElementById("btnC");
let btnD = document.getElementById("btnD");
let userScore = document.getElementById("score");
let countCarrots = 0;

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
  countCarrots += 20;

  btnA.removeEventListener("click", IncorrectAnswer);
  btnB.removeEventListener("click", IncorrectAnswer);
  btnC.removeEventListener("click", FirstAnswerCorrect);
  btnD.removeEventListener("click", IncorrectAnswer);

  userScore.innerHTML = "Zdobytych marchewek: " + countCarrots.toString();
  DisplaySecondQuestion();
}

function DisplaySecondQuestion() {
    label.innerHTML = "Gdy młoda świnka się cieszy to może zacząć?";
    btnA.innerHTML = "A.Stawać na tylnich łapach";
    btnB.innerHTML = "B.Popcornować";
    btnC.innerHTML = "C.Syczeć";
    btnD.innerHTML = "D.Gruchotać";
    
    document.getElementById("btnA").addEventListener("click", IncorrectAnswer);
    document.getElementById("btnB").addEventListener("click", SecondAnswerCorrect);
    document.getElementById("btnC").addEventListener("click", IncorrectAnswer);
    document.getElementById("btnD").addEventListener("click", IncorrectAnswer);
}
function SecondAnswerCorrect() {

    btnA.removeEventListener("click", IncorrectAnswer);
    btnB.removeEventListener("click", SecondAnswerCorrect);
    btnC.removeEventListener("click", IncorrectAnswer);
    btnD.removeEventListener("click", IncorrectAnswer);

  countCarrots += 20;
  userScore.innerHTML = "Zdobytych marchewek: " + countCarrots.toString();
  DisplayThirdQuestion();
}
function DisplayThirdQuestion() {
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
  countCarrots += 60;
  quiz.innerHTML =
    "Gratulacje odpowiedziałeś poprawnie na wszystkie pytania. Otrzymujesz " +
    countCarrots.toString() +
    " marchewek!";
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
