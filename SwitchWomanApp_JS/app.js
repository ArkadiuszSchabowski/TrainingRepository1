const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Wybierz typ odzie�y: buty, bielizna\n', (typOdziezy) => {
    switch (typOdziezy) {
        case 'buty':
            rl.question('Wybierz rodzaj but�w: koturny, szpilki, kozaki\n', (typObuwia) => {
                switch (typObuwia) {
                    case 'koturny':
                        console.log('Tw�j wyb�r to koturny');
                        break;
                    case 'szpilki':
                        console.log('Tw�j wyb�r to szpilki');
                        debugger;
                        break;
                    case 'kozaki':
                        console.log('Tw�j wyb�r to kozaki');
                        break;
                    default:
                        console.log('Niew�a�ciwy wyb�r');
                        break;
                }
                rl.close();
                waitForExit();
            });
            break;
        case 'bielizna':
            rl.question('Wybierz typ bielizny: figi, stringi\n', (typBielizny) => {
                switch (typBielizny) {
                    case 'figi':
                        console.log('Tw�j wyb�r to figi');
                        break;
                    default:
                        console.log('Niew�a�ciwy wyb�r');
                        break;
                }
                rl.close();
            });
            break;
        default:
            console.log('Niew�a�ciwy wyb�r');
            rl.close();
            waitForExit();
            break;
    }
});
