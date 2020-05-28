/**
 * @class Employee
 */
class Employee {
    constructor(_id, _lastname, _firstname, _role, _salary, _hiredate) {
        this.id = parseInt(_id);
        this.lastname = _lastname;
        this.firstname = _firstname;
        this.email = this.firstname.substring(0, 1).toLowerCase() + this.lastname.toLowerCase() + "@email.fr";
        this.role = _role;
        this.salary = parseInt(_salary);
        this.hiredate = _hiredate;
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