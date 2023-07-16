const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Wybierz typ odzie¿y: buty, bielizna\n', (typOdziezy) => {
    switch (typOdziezy) {
        case 'buty':
            rl.question('Wybierz rodzaj butów: koturny, szpilki, kozaki\n', (typObuwia) => {
                switch (typObuwia) {
                    case 'koturny':
                        console.log('Twój wybór to koturny');
                        break;
                    case 'szpilki':
                        console.log('Twój wybór to szpilki');
                        debugger;
                        break;
                    case 'kozaki':
                        console.log('Twój wybór to kozaki');
                        break;
                    default:
                        console.log('Niew³aœciwy wybór');
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
                        console.log('Twój wybór to figi');
                        break;
                    default:
                        console.log('Niew³aœciwy wybór');
                        break;
                }
                rl.close();
            });
            break;
        default:
            console.log('Niew³aœciwy wybór');
            rl.close();
            waitForExit();
            break;
    }
});
