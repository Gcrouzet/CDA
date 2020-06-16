const Point = require("./Point");

class Wall extends Point {

    /** @var string */
    #material;

    constructor(_material,_x,_y) {
        super(_x,_y);
        this.#material = _material|| "wood";
    }
    getMaterial(){
        return this.#material;
    }

}
module.exports = Wall;