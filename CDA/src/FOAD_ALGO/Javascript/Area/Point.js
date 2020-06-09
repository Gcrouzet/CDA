class Point {
    /**
     * Constructeur: Initialise une nouvelle instance de la classe "Point"
     * @param int _x Coordonnée horizontale du point (abscisse). Valeur négative acceptée
     * @param int _y Coordonnée verticale du point (ordonnée). Valeur négative acceptée
     */
    constructor(_x, _y) {
        this.x = parseInt(_x || 0);
        this.y = parseInt(_y || 0);

    }
   
    move(_x, _y) {
        this.x = parseInt(_x);
        this.y = parseInt(_y);
    }
    duplicate() {
        return new Point(this.x, this.y);

    }

    copy(_point) {
        this.x = _point.x;
        this.y = _point.y;
    }
    rabbit(_point) {
       let p = _point.duplicate();
        _point.copy(this);
        this.copy(p);
    }
    
    /**
     * Retourne une représentation textuelle du Point
     * @return string Les coordonnées du Point
     */
    toString() {
        return "(" + this.x + "," + this.y + ")";
    }

}

module.exports = Point;


/**
 * Programme "Point"
 * Décrivez ci-dessous en quelques lignes le programme suivant
 * (utilité, finalité)
 * -instanciation objet
 * -affichage objet
 * -duplication d'objet
 * -copie de coordonée
 * -échange de coordonnée
 */

/*
let p1 = new Point(0, 1);
let p2 = new Point(2, 3);
let p3 = new Point(4, 5);
let p4;
let p5;

console.log(p1);     // affiche: Point { x: 0, y: 1 }
console.log(p2);     // affiche: Point { x: 2, y: 3 }
console.log(p3);     // affiche: Point { x: 4, y: 5 }

p4 = p3.duplicate();
console.log(p3 !== p4);         // affiche: true
console.log(p3.toString());     // affiche (4,5)
console.log(p4.toString());     // affiche: (4,5)

p2.copy(p1);
console.log(p1 !== p2);         // affiche: true
console.log(p1.toString());     // affiche:  (0,1)
console.log(p2.toString());     // affiche:  (0,1)

p1.rabbit2(p3);
console.log(p1 !== p3);         // affiche: true
console.log(p1.toString());     // affiche:  (4,5)
console.log(p3.toString());     // affiche:  (0,1)
*/
