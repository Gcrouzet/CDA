/**
 * @class Employee
 */
class Employee {
    constructor(_employee) {
        this.id = 0;
        this.lastname = "Doe";
        this.firstname = "John";
        this.role = "Unknown";
        this.salary = 0;
        this.hiredate = new Date();
        this.email = null;

        if(_employee !== undefined) { // si un objet est fourni en argument
            this.copy(_employee);
        }
    }
    /**
    * Analyse et copie les informations de l'objet fourni en argument
    * Seuls les valeurs des attributs nécessaires à l'objet actuel sont copiés.
    * @param Object _employee un objet quelconque à analyser et à copier
    */
    copy(_employee) {

        // si l'argument _employee n'est pas fourni, _employee = un objet litéral vide
        _employee = _employee || {};

        this.id = parseInt(_employee.id || 0);
        this.lastname = _employee.lastname || "Doe";
        this.firstname = _employee.firstname || "John";
        this.role = _employee.role || "Unknown";
        this.salary = parseInt(_employee.salary || 0);
        this.email = (this.firstname[0] + this.lastname).toLowerCase() + "@email.fr";

        // Recréation de l'objet Date à partir de la date fournie
        if (_employee.hiredate !== undefined) {
            this.hiredate = new Date(_employee.hiredate);
        }
    }




    getMonthlySalary() {
        return Math.round(this.salary / 12 * 0.75);
    }
    getSeniority() {
        let now = new Date();
        let diff = now - this.hiredate;
        diff = Math.floor(diff / (1000 * 60 * 60 * 24));
        let année = Math.floor(diff / 365);
        diff = diff - année * 365;
        let mois = Math.floor(diff / 30);
        diff = diff - mois * 30;
        let jour = diff;



        if (jour > 0 && mois > 0 && année > 0) {
            return année + " ans , " + mois + " mois et " + jour + " jours ";
        } else if (jour > 0 && mois > 0 && année == 0) {
            return mois + " mois et " + jour + " jours ";
        } else if (jour > 0 && mois == 0 && année == 0) {
            return jour + " jours ";
        } else {
            return "L'employé n'est pas encore dans l'entreprise";
        }
    }

    getSeniority2() {
        let now = new Date();
        let y = now.getFullYear() - this.hiredate.getFullYear(); // années
        let m = now.getMonth() - this.hiredate.getMonth(); // mois
        let d = now.getDate() - this.hiredate.getDate(); // jours
        let result = "";

        if (m < 0) {
            y--;
            m += 12;
        }

        if (d < 0) {
            m--;
            d = Math.floor(d + (365.25 / 12));
        }

        if (y > 0) {
            result += y + " année(s) ";
        }

        if (m > 0) {
            result += m + " mois ";
        }

        if (d > 0) {
            result += d + " jour(s) ";
        }

        return result;

    }
}

module.exports = Employee;



/** @var Employee employee1
var employee1 = new Employee(1, 'Doe', 'John', 'manager', 82000, new Date('2020-12-28')); // création d'un nouvel employé
var employee2 = new Employee(2, 'Crouzet', 'Gabriel', 'Boss', 500000, new Date('2010-10-21'));
var employee3 = new Employee(3, 'Torrenti', 'Sylvain', 'Expert (partage)', 150000, new Date('2018-02-20'));
var employee4 = new Employee(4, 'Schmitt', 'Joanna', 'Directrice', 250000, new Date('2015-08-18'));
var employee5 = new Employee(5, 'Hamza', 'Reda', 'Vendeur sénior', 70000, new Date('1950-05-10'));

/**  @var array employees
const employees = [employee1]; // tableau contenant les employés
employees.push(employee2, employee3, employee4, employee5);

console.log(employee1); // doit afficher l'objet "employee1"
console.log("Il y a " + employees.length + " employé(e)s."); // doit afficher "Il y a 5 employé(e)s."
console.log(employees); // export des employés dans la console


/** FIN ZONE NON EDITABLE (Ne pas modifier les lignes précédentes)

for (let i = 0; i < employees.length; i++) {
    console.log(employees[i].lastname + ' ' + employees[i].firstname + ', ' + employees[i].email + ', '
        + employees[i].getSeniority() + ', ' + employees[i].getMonthlySalary() + '€');
}

// comparer ancienneté


let senior = employees[0];
for (let index = 0; index < employees.length; index++) {
    if (employees[index].hiredate < senior.hiredate) {
        senior = employees[index];
    }

}
console.log("L'employé avec le plus d'ancienneté est " + senior.lastname + " " + senior.firstname);


//L'employé avec le plus haut salaire

let hautSalaire = employees[0];
for (let index = 0; index < employees.length; index++) {
    if (employees[index].salary > hautSalaire.salary) {
        hautSalaire = employees[index];
    }

}
console.log("L'employé avec le plus haut salaire est " + hautSalaire.lastname + " " + hautSalaire.firstname);

//L'employé avec le plus bas salaire

let basSalaire = employees[0];
for (let index = 0; index < employees.length; index++) {
    if (employees[index].salary < basSalaire.salary) {
        basSalaire = employees[index];
    }

}
console.log("L'employé avec le plus bas salaire est " + basSalaire.lastname + " " + basSalaire.firstname);

//La différence de salaire entre les 2 précédents

let diffSalaire = hautSalaire.salary - basSalaire.salary;
console.log("La différence entre le plus haut et le plus bas salaire est de " + diffSalaire + "€.");
*/