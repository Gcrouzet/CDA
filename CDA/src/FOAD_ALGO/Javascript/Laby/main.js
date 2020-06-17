const Point = require("./Models/Point");
const Wall = require("./Models/Wall");
const Goal = require("./Models/Goal");
const Path = require("./Models/Path");
const Door = require("./Models/Door");


var door =new Door(0,2,"iron");
var goal =new Goal(5,0);
var path =new Path(0,1,true,1);
var wall =new Wall(0,2,"wood");

console.log(door instanceof Point);
console.log(door instanceof Wall);
console.log(goal instanceof Point);
console.log(path instanceof Point);
console.log(wall instanceof Point);
console.log(typeof door);
console.log(typeof wall);
console.log(typeof goal);
console.log(typeof path);






door.openClose();

console.log(door.getIsOpen());
