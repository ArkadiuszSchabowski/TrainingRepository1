'use strict';

console.log('Hello world');

function firstGameJavaScript() {
    for (let i = 0; i < 101; i++) {
        if (i % 15 == 0) {
            console.log("Hello Piggy");
        } else if (i % 5 == 0) {
            console.log("Hello");
        } else if (i % 3 == 0) {
            console.log("Hi");
        } else {
            console.log(i);
        }
    }
}

firstGameJavaScript();

debugger; // Zatrzymuje wykonanie programu, aby� m�g� zobaczy� wynik

// Konsola nie zostanie zamkni�ta po zatrzymaniu