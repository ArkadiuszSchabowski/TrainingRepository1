function DisplayTime(){
    let date = new Date();
    let timer = document.getElementById("time");
    timer.innerHTML = date.toLocaleTimeString();
}

setInterval(DisplayTime, 1000);