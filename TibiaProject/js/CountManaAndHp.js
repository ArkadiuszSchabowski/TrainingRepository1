let btnOk = document.getElementById("btnOk");
let btnClear = document.getElementById("btnClear");
let inputText = document.getElementById("inputText");
let show = document.getElementById("show");
let vocation = document.getElementById("vocation");
let level = document.getElementById("level");
let hp = document.getElementById("hp");
let mana = document.getElementById("mana");
let profession = document.getElementById("selectedProfession");
let hpPoints = 185;
let mpPoints = 35;

btnOk.addEventListener("click", Vocations);
btnClear.addEventListener("click", ClearValues);

function Vocations() {
  show.innerText = "";
  vocation.innerText = "";
  level.innerText = "";
  hp.innerText = "";
  mana.innerText = "";

  if (
    (profession.value === "") &
    (inputText.value < 8 || inputText.value > 300)
  ) {
    vocation.innerText = "Nieprawidłowy level";
    show.innerText = "Nie wybrano profesji";
    return;
  }

  if (profession.value === "") {
    vocation.innerText = "Nie wybrano profesji";
    return;
  }

  if (inputText.value < 8 || inputText.value > 300) {
    show.innerText = "Nieprawidłowy level";
    return;
  }

  if (profession.value === "druid" || profession.value === "sorcerer") {
    vocation.innerText = `Twoja profesja: ${profession.value}`;
    level.innerText = `Twój lvl: ${inputText.value}`;
    hp.innerText = `Twoje punkty życia to: ${
      hpPoints + (inputText.value - 8) * 5
    }`;
    mana.innerText = `Twoje punkty życia to: ${
      mpPoints + (inputText.value - 8) * 30
    }`;
    return;
  }

  if (profession.value === "knight") {
    vocation.innerText = `Twoja profesja: ${profession.value}`;
    level.innerText = `Twój lvl: ${inputText.value}`;
    hp.innerText = `Twoje punkty życia to: ${
      hpPoints + (inputText.value - 8) * 15
    }`;
    mana.innerText = `Twoje punkty życia to: ${
      mpPoints + (inputText.value - 8) * 5
    }`;
    return;
  }
  if (profession.value === "paladin") {
    vocation.innerText = `Twoja profesja: ${profession.value}`;
    level.innerText = `Twój lvl: ${inputText.value}`;
    hp.innerText = `Twoje punkty życia to: ${
      hpPoints + (inputText.value - 8) * 10
    }`;
    mana.innerText = `Twoje punkty życia to: ${
      mpPoints + (inputText.value - 8) * 15
    }`;
    return;
  }
}

function ClearValues() {
  show.innerText = "";
  vocation.innerText = "";
  level.innerText = "";
  hp.innerText = "";
  mana.innerText = "";
  profession.value = "";
  inputText.value = "";
}
