let tab = [1, 2, 3, 4, 5, 6, 7, 8, 9];

let x = 0;

for (let i = 0; i < tab.length; i++) {
    if (tab[i] == x) {
        console.log('L\'indice du chiffre donné est ' + i);
        break;
    }
    if (i = tab.length - 1) {
        console.log('le chiffre n\'est pas dans le tableau')
    }
}