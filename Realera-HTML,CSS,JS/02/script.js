let currentTime = function(){
    let time = new Date();
    document.getElementById("time").innerHTML = time.toLocaleTimeString();
}

setInterval(currentTime, 1000);

