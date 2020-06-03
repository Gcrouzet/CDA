const Employee = require('./Models/Employee');
const Entreprise = require('./Models/Entreprise');



let ubisoft = new Entreprise();

var employee1 = new Employee(1, 'Doe', 'John', 'manager', 82000, new Date('2020-12-28')); // création d'un nouvel employé
var employee2 = new Employee(2, 'Crouzet', 'Gabriel', 'Boss', 500000, new Date('2010-10-21'));
var employee3 = new Employee(3, 'Torrenti', 'Sylvain', 'Expert (partage)', 150000, new Date('2018-02-20'));
var employee4 = new Employee(4, 'Schmitt', 'Joanna', 'Directrice', 250000, new Date('2015-08-18'));
var employee5 = new Employee(5, 'Hamza', 'Reda', 'Vendeur sénior', 70000, new Date('1950-05-10'));


ubisoft.create(employee1);
ubisoft.create(employee2);
ubisoft.create(employee3);
ubisoft.create(employee4);
ubisoft.create(employee5);

/*ubisoft.delete(2);*/
/*console.log("Il y a " + ubisoft.employees.length + " employé(e)s.");
console.log(ubisoft); // export des employés dans la console*/
console.log(employee3);

console.log(ubisoft.read(3));
console.log(ubisoft.getHighestSalary());
console.log(ubisoft.getLowestSalary());
