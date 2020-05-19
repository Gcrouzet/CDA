const readline = require("readline");

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});


let collection = [
    "agathe",
    "berthe",
    "chloé",
    "cunégonde",
    "olga",
    "raymonde",
    "sidonie",
];

rl.question(
    "\n" + "Saisir un prénom :" + "\n",
    (answer) => {
        min = 0;
        max = collection.length - 1;
        mid = (min + max) / 2;
        prenom_present = false;
        prenom = answer;

        while (prenom_present == false && min <= max) {
            if (prenom.localeCompare(collection[mid]) == 0) {
                //trouvé
                prenom_present = true;
            } else if (prenom.localeCompare(collection[mid]) < 0) {
                //avant
                max = mid - 1;
            } else {
                //après
                min = mid + 1;
            }
            mid = (min + max) / 2;
        }

        if (prenom_present == true) {
            console.log("Prénom " + prenom + " trouvé à la case n ° " + (mid + 1) + "\n");
        } else {
            console.log("Prénom non trouvé " + "\n");
        }
        rl.close();
    });
