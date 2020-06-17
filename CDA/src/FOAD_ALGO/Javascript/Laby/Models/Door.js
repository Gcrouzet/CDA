const Wall = require("./Wall");

class Door extends Wall {

    /** @var string */
    #isOpen;

    constructor(_x, _y, _material) {
        super(_x, _y, _material)
        this.#isOpen = false;
    }
    getIsOpen() {
        return this.#isOpen;
    }
    openClose() {
        //this.#isOpen ? false : true;
        if (this.#isOpen === false) {
            this.#isOpen = true;
            return this.#isOpen;
        } else {
            this.#isOpen = false;
            return this.#isOpen;
        }

    }
}
module.exports = Door;