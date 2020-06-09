const Point = require('./Point.js');
const Area = require('./Area.js')

let area = new Area(8, 4)
var point1 = new Point(0, 1)


area.addPoint(point1);
area.movePoint(point1, 0, 0);

console.log(area);
