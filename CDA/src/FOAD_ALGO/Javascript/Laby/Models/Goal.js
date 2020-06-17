const Point = require("./Point");

class Goal extends Point {

    /** @var boolean */
    #success;

    constructor(_x,_y) {
        super(_x,_y);
        this.#success = true;
    }
    getSucces(){
        return this.#success;
    }

}
module.exports = Goal;