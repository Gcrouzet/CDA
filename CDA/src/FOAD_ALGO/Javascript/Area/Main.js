const Point = require('./Point.js');
const Area = require('./Area.js')

var area1 = new Area(4, 4);
var area2 = new Area(8, 6);
var point1 = new Point(0, 1);
var point2 = new Point(1, 0);
var point3 = new Point(0, 3);
var point4 = new Point(2, 0);
var point5 = new Point(0, 2);
var point6 = new Point(5, 4);
var point7 = new Point(0, 6);
var point8 = new Point(-1, 2);

var point11 = new Point(-5, -2);
var point12 = new Point(-2, -2);
var point13 = new Point(3, -8);
var point14 = new Point(9, 2);
var point15 = new Point(10, 7);
var point16 = new Point(8, 8);

var pointA = new Point(4, 4);
var pointB = pointA.duplicate();

area1.addPoint(point1);
area1.addPoint(point2);
area1.addPoint(point3);
area1.addPoint(point4);
area1.addPoint(point5);
area1.addPoint(point6);
area1.addPoint(point7);
area1.addPoint(point8);
area1.addPoint(pointA);


area2.addPoint(point11);
area2.addPoint(point12);
area2.addPoint(point13);
area2.addPoint(point14);
area2.addPoint(point15);
area2.addPoint(point16);
area2.addPoint(pointB);

//console.log(area1.notInside());
//console.log(area2.notInside());
area1.needAllInside();
console.log("Il y a " + area1.freeLocation() + " emplacements libres.");



console.log(area1);
//console.log(area2);
