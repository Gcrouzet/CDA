const Point = require("./Point");

class Goal extends Point {

    /** @var string */
    #success;

    constructor(_success) {
        super();
        this.#success = _success;
    }
    getSucces(){
        return this.#success;
    }

}
module.exports = Goal;