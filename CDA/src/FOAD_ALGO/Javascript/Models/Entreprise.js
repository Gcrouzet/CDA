const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {
    constructor() {
        this.employees = [];
    }
    /**
     * Valide un objet Employee
     * @param Employee _employee
     */
    isValid(_employee) {

        if (!(_employee instanceof Employee)) {
            return false;
        }
        return true;
    }
    /**
     * 
     * @param  _filter 
     */
    readAll(_filter) {
        return this.employees.filter(_filter);
    }


    /**
     * Créer un employé (valide les données de l'employé et l'ajoute à la collection)
     * @param Employee _employee 
     * @returns Employee L'objet Employee ajouté
     */
    create(_employee) {

        if (this.isValid(_employee)) {
            this.employees.push(_employee);
        }

        return _employee;
    }


    /**
     * 
     * @param int _id 
     */
    read(_id) {
        /* for (let i = 0; i < this.employees.length; i++) {
             if (this.employees[i].id === parseInt(_id)) {
                 return this.employees[i];
                 break;
             }
         }*/
        let emp = this.employees.find(emp => emp.id === parseInt(_id));

        if (emp !== undefined) {
            // retourner une copie de l'employé
            // cloner l'objet : let copie = Object.assign()
            // moteur de recherche : MDN JS object assign
            // moteur de recherche newbie: JS cloner objet
            let emp2 = Object.assign({}, emp)
            return emp2
        }

        return undefined;
    }

    /**
     * Met à jour un employé
     * @param Employee _employee 
     */
    update(_employee) {
        /*switch (_change) {
            case "lastname":
                return _employee.lastname = _new;
            case "firstname":
                return _employee.firstname = _new;
            case "role":
                return _employee.role = _new;
            case "salary":
                return _employee.salarye = _new;
            case "hiredate":
                return _employee.hiredate = _new;
            case "email":
                return _employee.emaile = _new;
            default:
                return _employee.id = _new;

        }*/
        if (!this.isValid(_employee)) {
            return _employee;
        }

        if (_employee.id < 1 && _employee.id !== NaN) {
            return _employee;
        }

        let exists = this.read(_employee.id);

        if (exists !== undefined && exists === _employee) {

        }

        return _employee;
    }
    /**
     * Supprime un employé
     * @param int _id 
     */
    delete(_id) {
        for (let i = 0; i < this.employees.length; i++) {
            if (this.employees[i].id == _id) {
                this.employees.splice(i, 1);
                break;
            }
        }
    }

    /**
     *
     */
    getHighestSalary() {
        this.employees.sort(function (a, b) {
            return b.salary - a.salary;
        });
        let higestSalary = this.employees[0];
        return higestSalary;
    }
    /**
     * 
     */
    getLowestSalary() {
        this.employees.sort(function (a, b) {
            return a.salary - b.salary;
        });
        let lowestSalary = this.employees[0];
        return lowestSalary;
    }

    /**
     * 
     */
    getSalaryGap(_employeeA, _employeeB) {
        let diff;
        if (_employeeA.salary == _employeeB.salary) {
            return "Ces deux employés perçoivent le même salaire";
        }
        if (_employeeA.salary > _employeeB.salary) {
            diff = _employeeA.salary - _employeeB.salary;
            return _employeeA.firstname + " perçoit " + diff + "€/an de plus que " + _employeeB.firstname;
        }
        if (_employeeB.salary > _employeeA.salary) {
            diff = _employeeB.salary - _employeeA.salary;
            return _employeeB.firstname + " perçoit " + diff + "€/an de plus que " + _employeeA.firstname;
        }
    }







}


module.exports = Enterprise;

